using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ch14.Code;
using System.IO;
using System.Drawing.Imaging;
namespace ch14
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            User.Getdefaultpic();
            pic.Image = User.defaultpic;
            dgvUser.DataSource = User.GetAllUserList();

            DataTable dt = User.GetAllItemList();
            listView1.Clear();
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dt.Rows[i]["itemname"].ToString();
                Item item = new Item(dt.Rows[i]["itemid"].ToString(), dt.Rows[i]["itemName"].ToString(), dt.Rows[i]["description"].ToString(),
                    Convert.ToDateTime(dt.Rows[i]["start_time"].ToString()), Convert.ToDateTime(dt.Rows[i]["end_time"].ToString()), dt.Rows[i]["hoster"].ToString());
                lvi.Tag = item;
                listView1.Items.Add(lvi);
            }

            dgvCheckIn.DataSource = User.GetAllCheckInList();

            try
            {
                using (StreamReader sr = new StreamReader("questions.txt"))
                {
                    cboQuestion.Items.Clear();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        cboQuestion.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            FrmAdmin_Load(null, null);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (txtUserKey.Text == "" || cboType.Text == "")
            {
                MessageBox.Show("信息为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string Field = "";
            if (cboType.Text == "用户名")
            {
                Field = "username";
            }
            else if (cboType.Text == "名字")
            {
                Field = "realname";
            }
            else if (cboType.Text == "等级")
            {
                Field = "level";
            }
            else if (cboType.Text == "邮箱")
            {
                Field = "email";
            }
            try
            {
                string sql = string.Format("select * from tb_user where {0} like '%{1}%'", Field, txtUserKey.Text);
                dgvUser.DataSource = SqlHelper.GetDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUser_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvUser.CurrentCell = dgvUser.Rows[e.RowIndex].Cells[1];
            dgvUser.Rows[e.RowIndex].Selected = true;
            if (e.RowIndex >= 0 && e.RowIndex < dgvUser.Rows.Count - 1)
            {
                DataTable dt = User.GetUserList("username", dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString());
                txtUsername.Text = dt.Rows[0]["username"].ToString();
                txtRealname.Text = dt.Rows[0]["realname"].ToString();
                txtPassword.Text = dt.Rows[0]["password"].ToString();
                cboLevel.Text = dt.Rows[0]["userlevel"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                cboQuestion.Text = dt.Rows[0]["question"].ToString();
                txtAnswer.Text = dt.Rows[0]["answer"].ToString();
                pic.Image = dt.Rows[0]["pic"] is DBNull ?  User.defaultpic : new Bitmap(new MemoryStream((byte[])(dt.Rows[0]["pic"])));
            }
            else
            {
                txtUsername.Text = txtRealname.Text = txtPassword.Text = cboLevel.Text = txtEmail.Text = cboQuestion.Text = txtAnswer.Text = "";
                pic.Image = User.defaultpic;
            }
        }


        private void btnUserDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除该用户及相关的签到信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                string name = txtUsername.Text;
                if (name == User.CurrentUser)
                {
                    MessageBox.Show("无法删除自己！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    string sql = string.Format("DELETE FROM tb_user WHERE username = '{0}'", name);
                    SqlHelper.ExcuteSQL(sql);
                    sql = string.Format("DELETE FROM tb_CheckIn WHERE username = '{0}'", name);
                    int m = SqlHelper.ExcuteSQL(sql);
                    MessageBox.Show("成功删除了此用户及" + m + "条签到信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show("没有找到相关的用户！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                FrmAdmin_Load(null, null);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtRealname.Text == "" || cboLevel.Text == ""
                || txtEmail.Text == "" || cboQuestion.Text == "" || txtAnswer.Text == "")
            {
                MessageBox.Show("请输入完整信息！", "温馨提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dt = User.GetUserList("username", txtUsername.Text);
            if (dt.Rows.Count > 0)
            {
                if (MessageBox.Show("已存在该用户，是否覆盖用户信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        if (pic.Image != User.defaultpic)
                        {
                            string sql = string.Format("UPDATE tb_user SET password = '{0}', realname = '{1}', userlevel = '{2}', email = '{3}', question = '{4}', answer = '{5}', pic = @Image WHERE username = '{6}' ",
                                txtPassword.Text, txtRealname.Text, cboLevel.Text, txtEmail.Text, cboQuestion.Text, txtAnswer.Text, txtUsername.Text
                                );
                            SqlHelper.ExcuteSQL(sql, pic.Image);
                        }
                        else
                        {
                            string sql = string.Format("UPDATE tb_user SET password = '{0}', realname = '{1}', userlevel = '{2}', email = '{3}', question = '{4}', answer = '{5}' WHERE username = '{6}' ",
                                txtPassword.Text, txtRealname.Text, cboLevel.Text, txtEmail.Text, cboQuestion.Text, txtAnswer.Text, txtUsername.Text
                                );
                            SqlHelper.ExcuteSQL(sql);
                        }
                        MessageBox.Show("更新成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "更新失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    FrmAdmin_Load(null, null);
                }
            }
            else
            {
                try
                {
                    if (pic.Image != User.defaultpic)
                    {
                        string sql = string.Format("INSERT INTO tb_user (username, password, realname, userlevel, email, question, answer, pic) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', @Image)",
                            txtUsername.Text, txtPassword.Text, txtRealname.Text, cboLevel.Text, txtEmail.Text, cboQuestion.Text, txtAnswer.Text);
                        SqlHelper.ExcuteSQL(sql, pic.Image);
                    }
                    else
                    {
                        string sql = string.Format("INSERT INTO tb_user (username, password, realname, userlevel, email, question, answer) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                            txtUsername.Text, txtPassword.Text, txtRealname.Text, cboLevel.Text, txtEmail.Text, cboQuestion.Text, txtAnswer.Text);
                        SqlHelper.ExcuteSQL(sql);
                    }
                    MessageBox.Show("添加成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                FrmAdmin_Load(null, null);
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {
            string pathname = "";
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = ".";
            file.Filter = "所有文件(*.*)|*.*";
            file.ShowDialog();
            if (file.FileName != string.Empty)
            {
                try
                {
                    pathname = file.FileName;
                    pic.Load(pathname);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //------------------------------------------第二个标签页--------------------------------------------
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtItemKey.Text == "" || cboField.Text == "")
            {
                MessageBox.Show("信息为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string field = "";
            if (cboField.Text == "签到人")
            {
                field = "username";
            }
            else if (cboField.Text == "签到时间")
            {
                field = "checktime";
            }
            else if (cboField.Text == "ip")
            {
                field = "ip";
            }
            else
            {
                field = "itemid";
            }
            dgvCheckIn.DataSource = User.GetCheckInList(field, txtItemKey.Text);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FrmAdmin_Load(null, null);
        }

        private void dgvCheckIn_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvUser.Rows.Count - 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    string id = dgvCheckIn.Rows[e.RowIndex].Cells[2].Value.ToString();
                    DataTable dt = User.GetItemList("itemid", id);
                    txtName.Text = dt.Rows[0]["itemName"].ToString();
                    txtContent.Text = dt.Rows[0]["description"].ToString();
                    txtStart.Text = dt.Rows[0]["start_time"].ToString();
                    txtEnd.Text = dt.Rows[0]["end_time"].ToString();
                    txtDeliver.Text = dt.Rows[0]["hoster"].ToString();
                }
                if (e.Button == MouseButtons.Right)
                {
                    this.contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtStart.Text == "" || txtEnd.Text == "" || txtDeliver.Text == "" || txtContent.Text == "" )
            {
                MessageBox.Show("请输入完整信息！", "温馨提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                DataTable dt = User.GetItemList("itemName", txtName.Text);
                if (dt.Rows.Count > 0)
                {
                    if (MessageBox.Show("已经存在该签到名, 是否覆盖", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {
                        string sql = string.Format("UPDATE tb_item SET description = '{0}', start_time = '{1}', end_time = '{2}', hoster = '{3}' WHERE itemName = '{4}' ",
                                txtContent.Text, txtStart.Text, txtEnd.Text, txtDeliver.Text, txtName.Text
                                );
                        SqlHelper.ExcuteSQL(sql);
                        MessageBox.Show("更新成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmAdmin_Load(null, null);
                    }
                }
                else
                {
                    string sql = string.Format("INSERT INTO tb_item (itemName, description, start_time, end_time, hoster) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", txtName.Text, txtContent.Text, txtStart.Text, txtEnd.Text, txtDeliver.Text);
                    SqlHelper.ExcuteSQL(sql);
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            FrmAdmin_Load(null, null);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除该签到项目及相关的签到信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    string sql = string.Format("SELECT * FROM tb_item WHERE itemName = '{0}'", txtName.Text);
                    DataTable dt = SqlHelper.GetDataTable(sql);
                    int id = Convert.ToInt32(dt.Rows[0]["itemid"].ToString());
                    sql = string.Format("DELETE FROM tb_item WHERE itemid = '{0}'", id);
                    SqlHelper.ExcuteSQL(sql);
                    sql = string.Format("DELETE FROM tb_CheckIn WHERE itemid = '{0}'", id); 
                    int m = SqlHelper.ExcuteSQL(sql);
                    MessageBox.Show("删除成功！一共删除" + m + "项相关的签到信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show("没有找到相关的签到项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                FrmAdmin_Load(null, null);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem current = listView1.SelectedItems[0];
                Item item = current.Tag as Item;
                txtName.Text = item.ItemName;
                txtContent.Text = item.Description;
                txtStart.Text = item.StartDate.ToString();
                txtEnd.Text = item.EndDate.ToString();
                txtDeliver.Text = item.Hoster;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该签到信息？", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    string id = dgvCheckIn.CurrentRow.Cells[0].Value.ToString();
                    string sql = string.Format("DELETE FROM tb_CheckIn WHERE checkid = '{0}'", id);
                    SqlHelper.ExcuteSQL(sql);
                    MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                FrmAdmin_Load(null, null);
            }
        }
        // ==================================================================================
        private void 用户视图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
            FrmCheckIn f = new FrmCheckIn();
            f.Show();
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.UserLevel = 0;
            User.CurrentUser = null;
            this.DestroyHandle();
            User.F.Show();
        }

        private void 查看帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("..\\..\\..\\README.md");
        }

    }
}

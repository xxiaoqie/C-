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

namespace ch14
{
    public partial class FrmCheckIn : Form
    {
        public FrmCheckIn()
        {
            InitializeComponent();
        }

        private void FrmCheckIn_Load(object sender, EventArgs e)
        {
            if (User.UserLevel == 1)
            {
                管理员视图ToolStripMenuItem.Enabled = true;
            }

            this.button1.Enabled = false;

            string sqltext = string.Format("SELECT * FROM tb_item");

            DataTable dt = SqlHelper.GetDataTable(sqltext);
            if (dt.Rows.Count>0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = row["itemname"].ToString();

                    Item item = new Item();
                    item.ItemId = row["itemid"].ToString();
                    item.ItemName = row["itemName"].ToString();
                    item.Description = row["description"].ToString();
                    item.StartDate = Convert.ToDateTime(row["start_time"].ToString());
                    item.EndDate = Convert.ToDateTime(row["end_time"].ToString());
                    item.Hoster = row["hoster"].ToString();
                    //这里有个trick
                    lvi.Tag = item;

                    listView1.Items.Add(lvi);
                }
            }

        }
        //记录当前签到项目id
        string current_item_id = "";
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
              ListViewItem current=  listView1.SelectedItems[0];
                Item item =current.Tag as Item;
                this.textBox1.Text = item.ItemName;
                this.textBox2.Text = item.Description;
                this.textBox3.Text = item.StartDate.ToString();
                this.textBox4.Text = item.EndDate.ToString();
                this.textBox5.Text = item.Hoster;
                //获取当前签到项目
                current_item_id = item.ItemId;
                //检查是否签到
                if (User.IsChecked(User.CurrentUser,current_item_id))
                {
                    this.button1.Enabled = false;
                }
                else
                {
                    this.button1.Enabled = true;
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.Net.IPHostEntry myEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
            string ipAddress = myEntry.AddressList[1].ToString();


            string sqltext = string.Format("INSERT INTO tb_CheckIn(username,itemid,checktime,ip)VALUES('{0}','{1}','{2}','{3}')",
                User.CurrentUser, current_item_id, DateTime.Now, ipAddress
                );

           int n= SqlHelper.ExcuteSQL(sqltext);
           if (n>0)
           {
               MessageBox.Show("签到成功！");
               button1.Enabled = false;
           }
        }

        private void FrmCheckIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void 管理员视图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
            FrmAdmin f = new FrmAdmin();
            f.Show();
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.UserLevel = 0;
            User.CurrentUser = null;
            this.DestroyHandle();
            User.F.Show();
        }

        private void 修改信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modify f = new Modify();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                退出登录ToolStripMenuItem_Click(null, null);
            }
        }

        private void 查看帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("..\\..\\..\\README.md");
        }
    }
}

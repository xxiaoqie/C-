using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ch14.Code;
namespace ch14
{
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }

        private void btnCle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPwd.Text == "" && txtEmail.Text == "" && txtA.Text == "")
                {
                    MessageBox.Show("信息不完整");
                    return;
                }
                if (txtPwd.Text != "")
                {
                    User.ModifyPassword(User.CurrentUser, txtPwd.Text);
                }
                if (txtEmail.Text != "")
                {
                    User.ModifyEmail(txtEmail.Text, User.CurrentUser);
                }
                if (cboQ.Text != "" && txtA.Text != "") 
                {
                    User.ModifySecurityQuestion(User.CurrentUser, cboQ.Text, txtA.Text);
                }
                MessageBox.Show("修改成功！");
            }
            catch (Exception)
            {
                throw;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void Modify_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("questions.txt"))
                {
                    cboQ.Items.Clear();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        cboQ.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

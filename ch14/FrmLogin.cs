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
namespace ch14
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.textBox1.Text;
            string password = this.textBox2.Text;
            int status = User.Login(username, password);
            User.CurrentUser = username;
            User.UserLevel = status;
            if (status==-1)
            {
                MessageBox.Show("失败", "登入失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                try
                {
                    using (StreamWriter sr = new StreamWriter("user.txt"))
                    {
                        if (cbaccount.Checked == true) sr.Write(textBox1.Text);
                        else sr.Write("");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if(status == 0) 
                {
                    this.Hide();
                    User.F = this;
                    FrmCheckIn f = new FrmCheckIn();
                    f.Show();
                }
                else if (status == 1)
                {
                    this.Hide();
                    User.F = this;
                    FrmAdmin f = new FrmAdmin();
                    f.Show();
                }    
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("user.txt"))
                {
                    textBox1.Text = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}

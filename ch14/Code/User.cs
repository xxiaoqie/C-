using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace ch14.Code
{
    class User
    {
        private static Dictionary<string, string> dic = new Dictionary<string, string>();
        private static Dictionary<string, string> rdic = new Dictionary<string, string>();
        public static Bitmap defaultpic; 
        private static string currentUser;

        public static string CurrentUser
        {
            get { return User.currentUser; }
            set { User.currentUser = value; }
        }

        private static int userLevel=0;

        public static int UserLevel
        {
            get { return User.userLevel; }
            set { User.userLevel = value; }
        }

        private static FrmLogin f = null;

        public static FrmLogin F
        {
            get { return User.f; }
            set { User.f = value; }
        }

        public static void Getdefaultpic() 
        {
            try
            {
                Stream fr = new FileStream("default.jpg", FileMode.Open, FileAccess.Read, FileShare.Read);
                byte[] fb = new byte[fr.Length];
                fr.Read(fb, 0, fb.Length);
                defaultpic = new Bitmap(new MemoryStream(fb));
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        /// <summary>
        /// 用户登录验证
        /// </summary>
        /// <param name="uname">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns>结果</returns>
        public static int Login(string uname, string pwd)
        {

            string sqltext = string.Format("SELECT * FROM tb_user WHERE username='{0}' AND password='{1}'", uname, pwd);

            DataTable dt = SqlHelper.GetDataTable(sqltext);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["userlevel"]);
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// 检查是否签到
        /// </summary>
        /// <param name="username"></param>
        /// <param name="itemid"></param>
        /// <returns></returns>
        public static bool IsChecked(string username, string itemid)
        {
            string sqltext = string.Format("SELECT * FROM tb_CheckIn WHERE username='{0}' AND itemid='{1}'", username, itemid);
            DataTable dt = SqlHelper.GetDataTable(sqltext);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }

        /// <summary>
        /// 修改用户密码
        /// </summary>
        /// <returns></returns>
        public static bool ModifyPassword(string username,string newpassword)
        {
            //update语句
            try
            {
                string sql = string.Format("UPDATE tb_user SET password = '{0}' WHERE username = '{1}'", newpassword, username);
                int n = SqlHelper.ExcuteSQL(sql);
                return n > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 修改用户安全问答
        /// </summary>
        /// <returns></returns>
        public static bool ModifySecurityQuestion(string username, string question,string answer)
        {
            //update语句
            try
            {
                string sql = string.Format("UPDATE tb_user SET question = '{0}', answer = '{1}' WHERE username = '{2}'", question, answer, username);
                int n = SqlHelper.ExcuteSQL(sql);
                return n > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool ModifyEmail(string email, string username)
        {
            try
            {
                string sql = string.Format("UPDATE tb_user SET email = '{0}' WHERE username = '{2}'", email, username);
                int n = SqlHelper.ExcuteSQL(sql);
                return n > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetItemList(string field, string key)
        {
            try
            {
                string sql = string.Format("select * from tb_item where {0} = '{1}'", field, key);
                DataTable dt = SqlHelper.GetDataTable(sql);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetAllItemList()
        {
            try
            {
                rdic.Clear();
                dic.Clear();
                string sql = "select * from tb_item";
                DataTable dt = SqlHelper.GetDataTable(sql);
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    dic[dt.Rows[i]["itemid"].ToString()] = dt.Rows[i]["itemName"].ToString();
                    rdic[dt.Rows[i]["itemName"].ToString()] = dt.Rows[i]["itemid"].ToString();
                }

                dt.Columns.Add("itemname", typeof(string));
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    dt.Rows[i]["itemname"] = dt.Rows[i]["itemid"].ToString() + ":" + dic[dt.Rows[i]["itemid"].ToString()];
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetCheckInList(string field, string key)
        {
            try
            {
                string sql = string.Format("select * from tb_CheckIn where {0} = '{1}'", field, key);
                DataTable dt = SqlHelper.GetDataTable(sql);
                dt.Columns.Add("itemname", typeof(string));
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    dt.Rows[i]["itemname"] = dt.Rows[i]["itemid"].ToString() + ":" + dic[dt.Rows[i]["itemid"].ToString()];
                }
                return dt;
            }
            catch (Exception ex)
            {  
                throw ex;
            }
        }



        public static DataTable GetAllCheckInList()
        {
            //select 语句
            try
            {
                string sql = string.Format("SELECT * FROM tb_CheckIn");
                DataTable dt = SqlHelper.GetDataTable(sql);
                dt.Columns.Add("itemname", typeof(string));
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    dt.Rows[i]["itemname"] = dt.Rows[i]["itemid"].ToString() + ":" + dic[dt.Rows[i]["itemid"].ToString()];
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetUserList(string field, string key) 
        {
            try
            {
                string sql = string.Format("SELECT * FROM tb_user where {0} = '{1}'", field, key);
                DataTable dt = SqlHelper.GetDataTable(sql);
                return dt;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public static DataTable GetAllUserList()
        {
            try
            {
                string sql = "select * from tb_user";
                DataTable dt = SqlHelper.GetDataTable(sql);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

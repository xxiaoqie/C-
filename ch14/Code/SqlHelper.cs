using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;



namespace ch14.Code
{
    class SqlHelper
    {
        static string connstr = ConfigurationManager.ConnectionStrings["main"].ConnectionString;

        //直接上来执行sql 语句 一般用来执行update insert delete三种操作
        public static int ExcuteSQL(string sql)
        {
            using (SqlConnection sqlconn=new SqlConnection (connstr))
            {
                using (SqlCommand sqlcmd=new SqlCommand (sql,sqlconn))
                {
                    //一定要有这条语句
                    sqlconn.Open();

                    int n = sqlcmd.ExecuteNonQuery();
                    return n;
                }
            }
        }

        public static int ExcuteSQL(string sql, Image pic)
        {
            using (SqlConnection sqlconn = new SqlConnection(connstr))
            {
                using (SqlCommand sqlcmd = new SqlCommand(sql, sqlconn))
                {
                    //一定要有这条语句
                    sqlconn.Open();

                    Bitmap bm = new Bitmap(pic);
                    MemoryStream ms = new MemoryStream();
                    bm.Save(ms, ImageFormat.Jpeg);
                    sqlcmd.Parameters.Add("Image", SqlDbType.Image);
                    sqlcmd.Parameters["Image"].Value = ms.GetBuffer();
                    int n = sqlcmd.ExecuteNonQuery();
                    return n;
                }
            }
        }

        //获取数据表信息
        public static DataTable GetDataTable(string sql)
        {
            using (SqlConnection sqlconn = new SqlConnection(connstr))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(sql, sqlconn))
                {
                    //这条语句可有可无
                    //sqlconn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds.Tables[0];

                }
            }
        }


    }
}

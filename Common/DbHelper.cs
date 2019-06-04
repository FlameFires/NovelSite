using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Common
{
    public class DbHelper
    {
       public static IDbConnection connection = new SqlConnection("Data Source=.;Initial Catalog=NovelWeb;User ID=sa;Password=123");
        //public static string connectionString= new SqlConnection("Server=(local);Database=NovelWeb;UID=sa;PWD=123").ConnectionString;

        /// <summary>
        /// 获取表格数据
        /// </summary>
        /// <param name="connection"></param>//链接数据库字符串
        /// <param name="strWhere"></param>查询条件
        /// <returns></returns>
        public static DataTable SeekData(string TableName, string strWhere)
        {
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=NovelWeb;User ID=sa;Password=123");
            ConnectionState connstate = connection.State;  //获取数据库的链接状态
            if (connstate != ConnectionState.Open)
            {    //是否链接
                connection.Open();
            }
            DataSet ds = new DataSet();
            try
            {
                IDbCommand cmd = connection.CreateCommand();//创建一个sql执行器
                cmd.CommandText = " select *  from ";//sql语句
                if (TableName.Trim() != "")
                {
                    cmd.CommandText += " " + TableName + " ";
                }
                if (strWhere.Trim() != "")
                {
                    cmd.CommandText += " where " + strWhere + "";
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd.CommandText,connection);
                adapter.Fill(ds, "ds");
                return ds.Tables[0];
            }
            finally
            {
                if (connstate == ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }
    }
}

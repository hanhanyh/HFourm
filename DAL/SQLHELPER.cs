using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace DAL
{
    class SQLHELPER
    {
        public static string config = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
        /// <summary>
        /// 返回首行首列
        /// </summary>
        /// <param name="sqlcomm"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public  static object ExecuteScalar(string sqlcomm,SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(config))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand( );
                comm.CommandText = sqlcomm;
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddRange(parameters);
                return     comm.ExecuteScalar();
            }
        }
        /// <summary>
        /// 返回数据集
        /// </summary>
        /// <param name="sqlcomm"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(string sqlcomm, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(config))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand.Connection = conn;
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.SelectCommand.Parameters.AddRange(parameters);
                adapter.SelectCommand.CommandText = sqlcomm;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;


            }
        }
        /// <summary>
        /// 返回受影响行数
        /// </summary>
        /// <param name="sqlcomm"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sqlcomm, SqlParameter[] parameters)
        {
            using (SqlConnection conn=new SqlConnection(config))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandText = sqlcomm;
                comm.CommandType = CommandType.Text;
                comm.Connection = conn;
                comm.Parameters.AddRange(parameters);
                return   comm.ExecuteNonQuery();
            }
        }
    }
}

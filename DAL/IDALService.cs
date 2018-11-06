using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace DAL
{
    /// <summary>
    /// 链路层接口
    /// </summary>
    /// <typeparam name="T">模型</typeparam>
    interface IDALService<T>
    {
         int add(T entity);
         int delete(int id);
        DataSet select(string sqlcomm, SqlParameter[] parameters);
        DataSet selectall();
         int update(T entity);
    }
}

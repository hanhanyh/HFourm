using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
    public class UserInfoService : IDALService<UserInfo>
    {
        public int add(UserInfo entity)
        {
            string sqlstr = "  insert into dbo.UserInfo( Name, NickName, PassWord, Sex, Birthday, Address, EMail)VALUES(@Name,@NickName,@Password,@Sex,@Birthday,@Address,@Email)";
            SqlParameter[] parameters = {
                new SqlParameter("@Name",entity.Name),
                new SqlParameter("@NickName",entity.NickName),
                new SqlParameter("@Password",entity.PassWord),
                new SqlParameter("@Sex",entity.Sex),
               new SqlParameter("@Birthday",entity.Birthday),
                 new SqlParameter("@Address",entity.Address),
                new SqlParameter("@Email",entity.EMail)
            };
           return    SQLHELPER.ExecuteNonQuery(sqlstr, parameters);
        }

        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataSet select(string sqlcomm, SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        public DataSet selectall()
        {
            throw new NotImplementedException();
        }

        public int update(UserInfo entity)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int login(UserInfo entity)
        {
            string sqltext = "select COUNT(*) from dbo.UserInfo where Name=@name and PassWord=@pwd";
            SqlParameter[] parameters = {
                    new SqlParameter("@name",entity.Name),
                    new SqlParameter("@pwd",entity.PassWord)
            };
            return Convert.ToInt32( SQLHELPER.ExecuteScalar(sqltext, parameters));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
   public  class UserInfoBLL
    {
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Regster(UserInfo entity)
        {
           return  new UserInfoService().add(entity);
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public int login(string name, string pwd)
        {
            return new UserInfoService().login(new UserInfo()
            {
                Name = name,
                PassWord = pwd
            });
        }
    }
}

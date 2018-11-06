using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using BLL;
using UI.Filters;
namespace UI.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
             
            //UserInfoBLL ub = new UserInfoBLL();
            //UserInfo uinfo = new UserInfo();
            //uinfo.Name = "xx";
            //uinfo.NickName = "nck";
            //uinfo.PassWord = "xscsd";
            //uinfo.Sex = 1;
            //uinfo.Birthday = "";
            //uinfo.EMail = "";
            //uinfo.Address = "";
            //ub.Regster(uinfo);
            return View();
             
        }
        public ActionResult Login()
        {
            return View();
        }
        /// <summary>
        /// 登录接收
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult doLogin(UserInfo userInfo)
        {
            int loginre=  new UserInfoBLL().login(userInfo.Name, userInfo.PassWord);
            if (loginre == 1)
            {
                ViewBag.result = true;
            }
            else
            {
                ViewBag.result = false;
            }
                
             return View();
        }
      
    }
}
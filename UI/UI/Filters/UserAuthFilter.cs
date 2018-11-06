using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace UI.Filters
{
    public class UserAuthFilter : FilterAttribute, IActionFilter
    {
        /// <summary>
        /// 执行后
        /// </summary>
        /// <param name="filterContext"></param>
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
              
        }
        /// <summary>
        /// 执行前
        /// </summary>
        /// <param name="filterContext"></param>
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["username"] == null)
            {
                filterContext.HttpContext.Response.Redirect("~/Home/Index");
            }
        }
    }
}
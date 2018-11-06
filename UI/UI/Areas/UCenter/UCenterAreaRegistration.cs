using System.Web.Mvc;

namespace UI.Areas.UCenter
{
    public class UCenterAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "UCenter";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
               name: "UCenter_default",
               url: "UCenter/{controller}/{action}/{id}",
               namespaces:new string[] { "UI.Areas.UCenter.Controllers" },
              defaults:  new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
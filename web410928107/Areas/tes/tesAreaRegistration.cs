using System.Web.Mvc;

namespace web410928107.Areas.tes
{
    public class tesAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "tes";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "tes_default",
                "tes/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
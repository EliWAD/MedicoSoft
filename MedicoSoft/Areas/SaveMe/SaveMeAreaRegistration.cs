using System.Web.Mvc;

namespace MedicoSoft.Areas.SaveMe
{
    public class SaveMeAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "SaveMe";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            //routes uniquement applicable dans la zone SaveMe
            context.MapRoute(
                "SaveMe_default",
                "SaveMe/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
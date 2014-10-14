using DAL;
using MedicoSoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicoSoft.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        public ActionResult Index()
        {
            if(MySession.Login == null)
            return RedirectToRoute(new{ controller = "Login" , action ="Form"});          
            
            List<Utilisateur> maListe = Utilisateur.getInfos();
            //MySession.isMedecin = MySession.User.getRole() == TypeOfUser.Medecin;
        }

        public ActionResult Liste(Utilisateur u)
        {


            Medecin me = MySession.User.ConvertMedecin();
            return RedirectToRoute(new { controller = "Login", action = "Form" });
            
        }

        
	}
}
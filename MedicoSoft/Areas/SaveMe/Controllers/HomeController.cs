using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicoSoft.Areas.SaveMe.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /SaveMe/Home/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string numRegNational)
        {
            //récup info sur la personne
            Personne p = Personne.getInfo(numRegNational);
            string nomMedecin = "";
            if (p != null)
            {
                if (p.getReferent(out nomMedecin))            // out permet les données d'être renvoyés : la fct crée la zone mémoire et renvoie les données
                {
                    return View(p);

                }
                else
                {

                    return View("Death",p);

                }

            }
            else
            {
                return View("Death", p);
            }

        }

    }
    
}
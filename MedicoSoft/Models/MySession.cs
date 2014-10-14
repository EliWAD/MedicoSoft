using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicoSoft.Models
{
    //equivalent à utils.cs
    public static class MySession
    {
        public static string Login
        {
            get{
                try
                {
                    return HttpContext.Current.Session["Login"].ToString();

                }
                catch (Exception)
                {
                    return null;
                } 
            }
            set{ HttpContext.Current.Session["Login"]= value;}
        }

        public static Utilisateur User
        {
            get { return (Utilisateur)HttpContext.Current.Session["User"]; }
            set { HttpContext.Current.Session["User"] = value; }

        }

        public static bool isMedecin
        {
            get { return (bool)HttpContext.Current.Session["isMedecin"]; }
            set { HttpContext.Current.Session["isMedecin"] = value; }
        }
    }
}
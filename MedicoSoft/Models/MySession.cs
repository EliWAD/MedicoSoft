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
            get{ return HttpContext.Current.Session["Login"].ToString();}
            set{ HttpContext.Current.Session["Login"].ToString();}
        }
    }
}
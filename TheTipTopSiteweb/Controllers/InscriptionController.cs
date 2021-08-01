//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using ThetiptopSite;
//using TheTipTopSiteweb.Models;

//namespace ThetiptopSite
//{
//    public class InscriptionController : Controller
//    {
//        private readonly thetiptoptestContext thetiptoptestContext;


//        public InscriptionController(thetiptoptestContext thetiptoptestContext)
//        {


//            this.thetiptoptestContext = thetiptoptestContext;

//        }

//        [HttpGet]
//        public IActionResult Index()
//        {
//            return View();
//        }



//        [HttpPost]

//        public void Login(Login login)
//        {
//            if (login != null)
//            {
//                var log = thetiptoptestContext.Users.Where(x => x.Email == login.LoginUser && x.Motdepasse == login.password);

//                if (log != null)
//                {
//                    Redirect("Home/Index");
//                }
//                else
//                {



//                }

//            }



//        }

//        [HttpPost]
//        public IActionResult Inscription(User user)
//        {
//            User AddUser = new();

//            AddUser.Nom = user.Nom;
//            AddUser.Pernom = user.Pernom;
//            AddUser.Datenaissance = user.Datenaissance;
//            AddUser.Email = user.Email;
//            AddUser.Telephone = user.Telephone;
//            AddUser.Adresse = user.Adresse;
//            AddUser.CodePostal = user.CodePostal;
//            AddUser.Ville = user.Ville;
//            AddUser.Pays = user.Pays;
//            AddUser.Iduser = 1;
//            AddUser.Motdepasse = user.Motdepasse;

//            thetiptoptestContext.Users.Add(AddUser);




//            return View();
//        }
//    }
//}

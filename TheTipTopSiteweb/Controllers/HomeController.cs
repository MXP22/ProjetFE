using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TheTipTopSiteweb.Models;

namespace TheTipTopSiteweb.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        public thetiptoptestContext thetiptoptestContext;
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(thetiptoptestContext thetiptoptestContext)
        {
            this.thetiptoptestContext = thetiptoptestContext;
        }



        public IActionResult Authface()
        {


            return Challenge(new AuthenticationProperties { RedirectUri = "/" });
        }

        public IActionResult Index()
        {
            //Participation participation = new Participation();
            //participation.DateInscription = DateTime.Now;
            //participation.Idconcours = 1;
            //participation.Idparticipation = 2;
            //participation.IdUser = 1;

            //thetiptoptestContext.Participations.Add(participation);
            //thetiptoptestContext.SaveChanges();


            return View();
        }
        [HttpPost]
        public IActionResult Index(Participation participation)
        {
            var lots = thetiptoptestContext.Lots.ToList();
            var coupons = thetiptoptestContext.Coupons.ToList();
            if (ModelState.IsValid)
            {
                var coupon = thetiptoptestContext.Coupons.FirstOrDefault(F => F.CodeCoupon == participation.Numerocoupon);

                if (coupon != null)
                {
                    coupon.Iduser = 1;
                    coupon.Etat = "Gain a récupérer";
                    thetiptoptestContext.SaveChanges();


                }
                var Lotinfo = from C in coupons join L in lots on C.Idlot equals L.Idlot select L;
                foreach (var lotsi in Lotinfo)
                {
                    ViewData["Id"] = lotsi.Idlot;
                    ViewData["Nom"] = lotsi.NomLot;
                    ViewData["Description"] = lotsi.DescriptionLot;
                }
            }
            return View(participation);
        }
        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Participer()
        {



            return View();

        }



        public IActionResult Historique()
        {




            return View();


        }




    }
}

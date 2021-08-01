using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheTipTopSiteweb.Models;
namespace TheTipTopSiteweb.Controllers
{
    public class HistoriqueController : Controller
    {
        private readonly thetiptoptestContext thetiptoptestContext;

        public HistoriqueController(thetiptoptestContext thetiptoptestContext)
        {
            this.thetiptoptestContext = thetiptoptestContext;


        }


        //Historique utilisateur
        [HttpGet]
        public IActionResult Index(int id)
        {

            var lots = thetiptoptestContext.Lots.ToList();
            var Coupons = thetiptoptestContext.Coupons.ToList();

            var histo = from C in Coupons join L in lots on C.Idlot equals L.Idlot where C.Iduser == id select L;
            if (histo != null)
            {


                return NotFound();
            }


            return View(histo);
        }



        //Visualiser les gains par employeur
        [HttpPost]
        public IActionResult GetGainByEmployer(Tuser user)
        {
            var Gain = thetiptoptestContext.Coupons.FirstOrDefault(c => c.Iduser == user.Iduser && c.Etat == "Validé");
            if (Gain != null)
            {


                return NotFound();
            }


            return View(Gain);

        }




    }
}

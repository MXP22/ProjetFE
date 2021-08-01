//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using TheTipTopSiteweb.Models;

//namespace TheTipTopSiteweb.Controllers
//{
//    public class ParticipationController : Controller
//    {
//        private readonly thetiptoptestContext thetiptoptestContext;

//        public ParticipationController (thetiptoptestContext theTipTopcontext)
//        {
//            this.thetiptoptestContext = theTipTopcontext;

//        }
//        [HttpGet]
//        public IActionResult Index()
//        {
//            Participation participation = new Participation();

//            participation.DateInscription = DateTime.Now;
//            //participation.IdUser = 2;
//            //participation.Idparticipation = 1;

//            thetiptoptestContext.Participations.Add(participation);
//            thetiptoptestContext.SaveChanges();

//            //var concours = thetiptoptestContext.Concours.ToList();

//            //var d = new SelectList(concours);



//            return View();
//        }

//        [HttpPost]
//        public IActionResult Index(Participation participation0)
//        {

//            Participation participation= new Participation();

//            participation.DateInscription = DateTime.Now;
//            participation.IdUser = 2;
//            participation.Idparticipation = 1;

//            thetiptoptestContext.Participations.Add(participation);




//            return View();
//        }
//    }
//}

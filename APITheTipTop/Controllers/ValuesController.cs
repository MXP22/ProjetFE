////using APITheTipTop.Models;
////using Microsoft.AspNetCore.Http;
////using Microsoft.AspNetCore.Mvc;
////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Threading.Tasks;

////namespace APITheTipTop.Controllers
////{
////    [ApiController]
////    [Route("[controller]/")]
////    public class ValuesController : ControllerBase
////    {
////        private readonly thetiptoptestContext thetiptoptestContext;

////        public ValuesController(thetiptoptestContext theTipTopcontext)
////        {
////            this.thetiptoptestContext = theTipTopcontext;

////        }

////        [Route("Number")]
////        [HttpGet]
////        public int Number()
////        {
////            int num = 0;
////            Random random = new Random();

////            num = random.Next(1000000000);
////            return num;

////        }
////        [Route("CodeParticipation")]
////        [HttpPost]
////        public int CodeParticipation(float PrixTicket)
////        {
////            int f = 0;
////            if (PrixTicket != 0 && PrixTicket >= 49)
////            {
////                Random random = new Random();

////                f = random.Next(1000000000);
////            }




////            return f;

//<<<<<<< HEAD
//        }
//        [Route("Getcoupon")]
//        [HttpGet]
//<<<<<<< HEAD
//        public string GetCoupon()
//=======
//        public string GetCoupon(double prix)
//>>>>>>> master
//        {
//            int f = 0;
//            while (theTipTopcontext.Coupon.Count() < 150000)
//            {
//=======
////        }
////        [Route("Getcoupon")]
////        [HttpGet]
////        public void GetCoupon()
//>>>>>>> master

////        {
////            int f = 0;
////            while (thetiptoptestContext.Coupons.Count() < 150000)
////            {


////                Random random = new Random();

////                f = random.Next(1000000000);

////                var c = new Coupon() { CodeCoupon = f, DateCreation = DateTime.Now, DatefFin = DateTime.Parse(DateTime.Now.AddMonths(1).ToString()), Etat = "Non distribué " };
////                var find = thetiptoptestContext.Coupons.Where(c => c.CodeCoupon != f);
////                if (find != null)
////                {
////                    thetiptoptestContext.Coupons.Add(c);
////                    thetiptoptestContext.SaveChanges();

////                }
////            }

////        }

      



////    }
////}

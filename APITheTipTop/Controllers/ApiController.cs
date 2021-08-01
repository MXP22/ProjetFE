using APITheTipTop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITheTipTop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly thetiptoptestContext thetiptoptestContext;

        public ApiController(thetiptoptestContext thetiptoptestContext)
        {
            this.thetiptoptestContext = thetiptoptestContext;
        }

        //[HttpGet]
        //public List<Coupon> GetCoupon()
        //{
        //    var Listcoupon = thetiptoptestContext.Coupons.ToList();



        //    return Listcoupon;

        //}
        //[HttpGet]
        //[Route("Get")]
        //public int Ticket()
        //{
        //    var Listcoupon = thetiptoptestContext.Coupons.ToList();
        //    int gain = 0;
        //    Coupon ticket = new Coupon();
        //    Random random = new Random();

        //    foreach (var ticketcode in Listcoupon)
        //    {
        //        gain = random.Next(ticketcode.Idcoupon);
        //    }


        //    if (gain != 0)
        //    {
        //        var ticke = (from T in Listcoupon where T.Idcoupon == gain select T).ToList();
        //        var entity = thetiptoptestContext.Coupons.FirstOrDefault(c => c.Idcoupon == gain);
        //        entity.Etat = "Distribué";
        //        thetiptoptestContext.SaveChanges();
        //        foreach (var T in ticke)
        //        {

        //            ticket = T;

        //        }

        //    }

        //    return 0;

        //}
        [HttpGet]
        [Route("Ticket")]
        public Coupon Ticket()
        {

            var Listcoupon = thetiptoptestContext.Coupons.ToList();


            int gain = 0;
            Coupon ticket = new Coupon();
            Random random = new Random();


            for (int i = 0; i < Listcoupon.Count; i++)
            {

                gain = random.Next(Listcoupon[i].Idcoupon);
            }


            if (gain != 0)
            {


                var ti = (from T in Listcoupon where T.Idcoupon == gain select T).ToList();
                var entity = thetiptoptestContext.Coupons.FirstOrDefault(item => item.Idcoupon == gain);
                entity.Etat = "Distribué";
                thetiptoptestContext.SaveChanges();
                foreach (var t in ti)
                {

                    ticket = t;



                }


            }

            return ticket;

        }




    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheTipTopSiteweb.Models;

namespace TheTipTopSiteweb.Controllers
{
    public class AdminController : Controller
    {
        private readonly thetiptoptestContext theTipTopcontext;

        public AdminController(thetiptoptestContext theTipTopcontext)
        {
            this.theTipTopcontext = theTipTopcontext;

        }

        [HttpGet]
        public IActionResult ListLot()
        {
            var listlot = theTipTopcontext.Lots.ToList();


            return View(listlot);
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreationTickit()
        {

            return View();
        }



        [HttpPost]
        public async Task<IActionResult> CreationTickit(Admin admin)
        {
            int f;
            while (theTipTopcontext.Coupons.Count() < 1500000)
            {
                Random random = new Random();


                for (int i = 0; i < 15000 * 0.60; i++)
                {
                    f = random.Next(1000000000);



                    var c = new Coupon() { CodeCoupon = f, DateCreation = DateTime.Now, DatefFin = DateTime.Parse(DateTime.Now.AddMonths(1).ToString()), Etat = "Non distribué", Idlot = 1 };


                    var find = theTipTopcontext.Coupons.Where(c => c.CodeCoupon != f);
                    if (find != null)
                    {
                        theTipTopcontext.Coupons.Add(c);
                        theTipTopcontext.SaveChanges();

                    }
                }

                for (int i = 0; i < 15000 * 0.10; i++)
                {
                    f = random.Next(1000000000);



                    var c = new Coupon() { CodeCoupon = f, DateCreation = DateTime.Now, DatefFin = DateTime.Parse(DateTime.Now.AddMonths(1).ToString()), Etat = "Non distribué", Idlot = 2 };


                    var find = theTipTopcontext.Coupons.Where(c => c.CodeCoupon != f);
                    if (find != null)
                    {
                        theTipTopcontext.Coupons.Add(c);
                        theTipTopcontext.SaveChanges();

                    }
                }
                for (int i = 0; i < 1500000 * 0.10; i++)
                {
                    f = random.Next(1000000000);



                    var c = new Coupon() { CodeCoupon = f, DateCreation = DateTime.Now, DatefFin = DateTime.Parse(DateTime.Now.AddMonths(1).ToString()), Etat = "Non distribué", Idlot = 3 };


                    var find = theTipTopcontext.Coupons.Where(c => c.CodeCoupon != f);
                    if (find != null)
                    {
                        theTipTopcontext.Coupons.Add(c);
                        theTipTopcontext.SaveChanges();

                    }
                }

                for (int i = 0; i < 15000 * 0.10; i++)
                {
                    f = random.Next(1000000000);



                    var c = new Coupon() { CodeCoupon = f, DateCreation = DateTime.Now, DatefFin = DateTime.Parse(DateTime.Now.AddMonths(1).ToString()), Etat = "Non distribué", Idlot = 4 };


                    var find = theTipTopcontext.Coupons.Where(c => c.CodeCoupon != f);
                    if (find != null)
                    {
                        theTipTopcontext.Coupons.Add(c);
                        theTipTopcontext.SaveChanges();

                    }
                }
                for (int i = 0; i < 15000 * 0.06; i++)
                {
                    f = random.Next(1000000000);



                    var c = new Coupon() { CodeCoupon = f, DateCreation = DateTime.Now, DatefFin = DateTime.Parse(DateTime.Now.AddMonths(1).ToString()), Etat = "Non distribué", Idlot = 5 };


                    var find = theTipTopcontext.Coupons.Where(c => c.CodeCoupon != f);
                    if (find != null)
                    {
                        theTipTopcontext.Coupons.Add(c);
                        theTipTopcontext.SaveChanges();

                    }
                }
                for (int i = 0; i < 15000 * 0.04; i++)
                {
                    f = random.Next(1000000000);



                    var c = new Coupon() { CodeCoupon = f, DateCreation = DateTime.Now, DatefFin = DateTime.Parse(DateTime.Now.AddMonths(1).ToString()), Etat = "Non distribué", Idlot = 6 };


                    var find = theTipTopcontext.Coupons.Where(c => c.CodeCoupon != f);
                    if (find != null)
                    {
                        theTipTopcontext.Coupons.Add(c);
                        theTipTopcontext.SaveChanges();

                    }
                }

            }




            return View();

        }

        [HttpGet]
        public IActionResult ListParticipantes()
        {

            var Participant = theTipTopcontext.Coupons.Where(E => E.Etat == "validé").ToList();



            return View(Participant);

        }

        [HttpGet]
        public IActionResult ListNonParticipantes()
        {

            var Participant = theTipTopcontext.Coupons.Where(E => E.Etat == "Non validé").ToList();



            return View(Participant);

        }

        [HttpGet]
        public IActionResult ListTicket()
        {

            var Participant = theTipTopcontext.Coupons.ToList();



            return View(Participant);

        }


        [HttpGet]

        public IActionResult ListeTicketDistribue()
        {
             

            return View();

        }








    }
}

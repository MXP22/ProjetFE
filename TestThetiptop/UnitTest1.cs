using APITheTipTop.Controllers;
using System;
using Xunit;

namespace TestThetiptop
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Get_Tickit_Random()
        {
            APITheTipTop.Models.thetiptoptestContext thetiptoptestContext = new APITheTipTop.Models.thetiptoptestContext();
            var Tickit = new ApiController(thetiptoptestContext).Ticket();

            var tick = thetiptoptestContext.Coupons;
             
          //  Assert.True(,);

        }
    }
}

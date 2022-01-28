using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01511170_Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {

        public IEnumerable<string> Get(int id)
        {
            double fortnights = id / 14;
            int fortnights1 = (int)fortnights + 1;
            double Charge = fortnights1 * 5.50;
            double Hst = fortnights1 * 0.72;
            double TotalCharge = Hst + Charge;
            return new string[] { fortnights1 +"fornights at $5.50/FN= $"+Charge+" CAD",
                 "HST 13% = $"+ Hst +" CAD",
                "Total=$"+ TotalCharge+" CAD"};
          
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01511170_Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        public int Get(int id)
        {
            return 10+20-5*4/2;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01511170_Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        public string Get(int id)
        {
            return "Greeting to " + id + " people";
        }
    }
}

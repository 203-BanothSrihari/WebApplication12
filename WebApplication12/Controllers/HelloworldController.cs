using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication12.Controllers
{
    public class HelloworldController : Controller
    {
        public string Index()
        {
            return "This is a default action";
        }
        public string Welcome()
        {
            return "This is a welcome action....";
        }
    }
}

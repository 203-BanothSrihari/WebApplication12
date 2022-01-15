using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication12.Controllers
{
    public class EmployeeController : Controller
    {
        public string Index()
        {
            return "This is default action....";
        }
        public string FirstName()
        {
            
            return "First Name is : Banoth.";
            LastName();
        }
        public string LastName()
        {
            return "Last name is : Srihari";
        }
    }
}

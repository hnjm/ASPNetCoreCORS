﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Cors.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Index Action";
        }
    }
}
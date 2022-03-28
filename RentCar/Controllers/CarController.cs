using Microsoft.AspNetCore.Mvc;
using RentCar.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Controllers
{
    public class CarController : Controller
    {
        private readonly AppDbContext _dbContext;

        public IActionResult Detail()
        {
            return View();
        }
    }
}

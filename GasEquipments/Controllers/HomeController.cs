using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GasEquipments.Models;

namespace GasEquipments.Controllers
{
    public class HomeController : Controller
    {

        EquipmentContext db;

        public HomeController(EquipmentContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult ChangeEquipment(int id, Equipment equipment)
        {
            return View(db.Equipments.Where(equip => equip.Id == id));
        }

        [HttpPost]
        public IActionResult ChangeEquipment(Equipment newEquipment)
        {
            db.Equipments.Update(newEquipment);
            db.SaveChanges();
            return RedirectToAction("Index");

        }


    [HttpGet]
        public IActionResult Measurements(int id)
        {
            ViewBag.EquipmentId = id;
            return View(db.Measurements.Where(measurements => measurements.EquipmentId==id).ToList());
        }


        [HttpPost]
        public IActionResult Measurements(Measurement measurements)
        {
            db.Measurements.Add(measurements);
            db.SaveChanges();
            return RedirectToPage("/Home/Measurements/" + measurements.EquipmentId);
        }
        

        [HttpGet]
        public IActionResult Index()
        {
            return View(db.Equipments.ToList());
        }

        [HttpPost]
        public IActionResult Index(Equipment equipment)
        {
            db.Equipments.Add(equipment);
            db.SaveChanges();
            return RedirectToPage("/Home");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

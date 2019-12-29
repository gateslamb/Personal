using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkoutPointSystem2.Models;

namespace WorkoutPointSystem2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
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

        public double CalculateFlatRunningPoints(double distance)
        {
            return (distance * 100);
        }

        public double CalculateTrailRunPoints(double distance, double elevGain)
        {
            return ((distance * 100) + (elevGain / distance));
        }

        public double CalculateHikePoints(double distance, double elevGain, double minutes)
        {
            return (((distance * 100) + (elevGain / distance)) / (minutes / 60));
        }

        public double CalculateStationaryBikePoints(double distance)
        {
            return ((distance / 3) * 100);
        }

        public double CalculateOutdoorBikePoints(double distance, double elevGain)
        {
            return (((distance / 3) * 100) + (elevGain / distance));
        }

        public double CalculateWorkoutPoints(double avgerageHB, double minutes)
        {
            return (avgerageHB * (minutes / 15));
        }

        public double CalculateSkiBoardSurfPoints(double minutes)
        {
            return (minutes / 30);
        }
    }
}

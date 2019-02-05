using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using TemperatureWebCore.Data;
using TemperatureWebCore.Models;

namespace TemperatureWebCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataRepository _repository;

        public HomeController(IDataRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            try
            {
                var timeFormat = "{0:yyyy-MM-dd HH:mm:ss}";
                var currentTemp = _repository.GetCurrentTemperature();
                var maxTemp = _repository.GetMaxTemperature();
                var minTemp = _repository.GetMinTemperature();

                if (currentTemp != null)
                {
                    ViewBag.CurrentTime = string.Format(timeFormat, currentTemp.Time);
                    ViewBag.CurrentTemp = currentTemp.Temperature.ToString("N1");
                }

                return View();
            }
            catch (Exception ex)
            {
                return BadRequest($"Error has occured: {ex.Message}");
            }
        }

        public IActionResult Dashboard()
        {
            try
            {
                var timeFormat = "{0:yyyy-MM-dd HH:mm:ss}";
                var currentTemp = _repository.GetCurrentTemperature();
                var maxTemp = _repository.GetMaxTemperature();
                var minTemp = _repository.GetMinTemperature();

                if (currentTemp != null)
                {
                    ViewBag.CurrentTime = string.Format(timeFormat, currentTemp.Time);
                    ViewBag.CurrentTemp = currentTemp.Temperature.ToString("N1");
                }

                if (maxTemp != null)
                {
                    ViewBag.MaxTime = string.Format(timeFormat, maxTemp.Time);
                    ViewBag.MaxTemp = maxTemp.Temperature.ToString("N1");
                }

                if (minTemp != null)
                {
                    ViewBag.MinTime = string.Format(timeFormat, minTemp.Time);
                    ViewBag.MinTemp = minTemp.Temperature.ToString("N1");
                }

                return View();
            }
            catch (Exception ex)
            {
                return BadRequest($"Error has occured: {ex.Message}");
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Shows current temperature as well as historical data";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact page";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

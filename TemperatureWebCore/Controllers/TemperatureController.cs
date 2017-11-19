using Microsoft.AspNetCore.Mvc;
using System;
using TemperatureWebCore.Data;

namespace TemperatureWebCore.Controllers
{
    public class TemperatureController : Controller
    {
        private readonly IDataRepository _repository;

        public TemperatureController(IDataRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Temperature()
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
    }
}

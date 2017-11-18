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
                ViewBag.Value = _repository.GetCurrentTemperature()?.Temperature;

                return View();
            }
            catch (Exception ex)
            {
                return BadRequest($"Error has occured: {ex.Message}");
            }
        }
    }
}

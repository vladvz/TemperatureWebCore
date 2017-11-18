using Microsoft.AspNetCore.Mvc;
using System;
using TemperatureWebCore.Data;
using TemperatureWebCore.Models;

namespace TemperatureWebCore.Controllers
{
    [Route("api/[Controller]")]
    public class MeasuresController : Controller
    {
        private readonly IDataRepository _repository;

        public MeasuresController(IDataRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var result = new Measure();

                if  (Request.Query.ContainsKey("Temp"))
                {
                    var tempType = Request.Query["Temp"];

                    if (tempType == "current")
                    {
                        result = _repository.GetCurrentTemperature();
                    }

                    if (tempType == "max")
                    {
                        result = _repository.GetMaxTemperature();
                    }

                    if (tempType == "min")
                    {
                        result = _repository.GetMinTemperature();
                    }
                }
                else
                {
                    result = _repository.GetCurrentTemperature();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error has occured: {ex.Message}");
            }
        }
    }
}

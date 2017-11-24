using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using TemperatureWebCore.Data;
using TemperatureWebCore.Models;

namespace TemperatureWebCore.Controllers
{
    public class MeasuresController : Controller
    {
        private readonly IDataRepository _repository;

        public MeasuresController(IDataRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("api/alltemp")]
        public IActionResult GetAllTemperatures()
        {
            try
            {
                var result = _repository.GetAllTemperatures();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error has occured: {ex.Message}");
            }
        }

        [HttpGet("api/dailytemps")]
        public IActionResult GetDailyTemperatures()
        {
            try
            {
                var result = _repository.GetDailyTemperatures();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error has occured: {ex.Message}");
            }
        }

        [HttpGet("api/dailytemps/{dateString}")]
        public IActionResult GetDailyTemperatures(string dateString)
        {
            try
            {
                if (DateTime.TryParseExact(dateString, "yyyy-MM-dd", null, DateTimeStyles.None, out DateTime date))
                {
                    var dailyTempList = _repository.GetDailyTemperatures(date);

                    return Ok(dailyTempList);
                }
                return BadRequest("Date is not in expected format");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error has occured: {ex.Message}");
            }
        }

        [HttpGet("api/currenttemp")]
        public IActionResult GetCurrentTemperature()
        {
            try
            {
                var result = _repository.GetCurrentTemperature();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error has occured: {ex.Message}");
            }
        }

        [HttpGet("api/maxtemp")]
        public IActionResult GetMaxTemperature()
        {
            try
            {
                var result = _repository.GetMaxTemperature();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error has occured: {ex.Message}");
            }
        }

        [HttpGet("api/mintemp")]
        public IActionResult GetMinTemperature()
        {
            try
            {
                var result = _repository.GetMinTemperature();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error has occured: {ex.Message}");
            }
        }
    }
}

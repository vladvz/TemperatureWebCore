﻿using Microsoft.AspNetCore.Mvc;
using System;
using TemperatureWebCore.Data;

namespace TemperatureWebCore.Controllers
{
    public class MeasuresController : Controller
    {
        private readonly IDataRepository _repository;

        public MeasuresController(IDataRepository repository)
        {
            _repository = repository;
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

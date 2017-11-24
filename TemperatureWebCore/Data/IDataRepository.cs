using System;
using System.Collections.Generic;
using TemperatureWebCore.Models;

namespace TemperatureWebCore.Data
{
    public interface IDataRepository
    {
        List<Measure> GetAllTemperatures();
        List<DailyTemperature> GetDailyTemperatures();
        List<Measure> GetDailyTemperatures(DateTime date);
        Measure GetCurrentTemperature();
        Measure GetMaxTemperature();
        Measure GetMinTemperature();
    }
}
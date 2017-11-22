using System.Collections.Generic;
using TemperatureWebCore.Models;

namespace TemperatureWebCore.Data
{
    public interface IDataRepository
    {
        List<Measure> GetAllTemperatures();
        List<DailyTemperature> GetDailyTemperatures();
        Measure GetCurrentTemperature();
        Measure GetMaxTemperature();
        Measure GetMinTemperature();
    }
}
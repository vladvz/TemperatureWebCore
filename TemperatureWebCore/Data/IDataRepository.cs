using System.Collections.Generic;
using TemperatureWebCore.Models;

namespace TemperatureWebCore.Data
{
    public interface IDataRepository
    {
        List<Measure> GetAllTemperatures();
        List<Measure> GetDailyMaxTemperatures();
        List<Measure> GetDailyMinTemperatures();
        Measure GetCurrentTemperature();
        Measure GetMaxTemperature();
        Measure GetMinTemperature();
    }
}
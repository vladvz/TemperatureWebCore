using TemperatureWebCore.Models;

namespace TemperatureWebCore.Data
{
    public interface IDataRepository
    {
        Measure GetCurrentTemperature();
        Measure GetMaxTemperature();
        Measure GetMinTemperature();
    }
}
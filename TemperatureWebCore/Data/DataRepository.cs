using System.Collections.Generic;
using System.Linq;
using TemperatureWebCore.Models;

namespace TemperatureWebCore.Data
{
    public class DataRepository : IDataRepository
    {
        private readonly TemperatureContext _context;

        public DataRepository(TemperatureContext context)
        {
            _context = context;
        }

        public List<Measure> GetAllTemperatures()
        {
            return _context.Measures.OrderBy(item => item.Id).ToList();
        }

        public Measure GetCurrentTemperature()
        {
            return _context.Measures.OrderByDescending(item => item.Id).FirstOrDefault();
        }

        public Measure GetMaxTemperature()
        {
            return _context.Measures.OrderByDescending(item => item.Temperature).FirstOrDefault();
        }

        public Measure GetMinTemperature()
        {
            return _context.Measures.OrderBy(item => item.Temperature).FirstOrDefault();
        }
    }
}

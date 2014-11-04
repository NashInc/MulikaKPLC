using MulikaKPLC.DataLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace MulikaKPLC.DataLayer.Utilities
{
    public static class ElectricalUtilities
    {
        public const double Voltage = 240.0f;

        public static void CalculatePower(this PowerReading reading)
        {
            var powerInWatts = Voltage * reading.CurrentValue;
            reading.PowerInWatts = powerInWatts;
        }

       

        private static SortedSet<PowerReading> SortReadings(IEnumerable<PowerReading> readings)
        {
            var sortedReadings = readings.OrderByDescending(x => x.DateOfReading);
            var sortedReadingslist = new SortedSet<PowerReading>(sortedReadings);
            return sortedReadingslist;
        }  
    }

    public class UnitBillingMetaData
    {
        public decimal  UnitPrice { get; set; }
        public decimal UnitFuelTax { get; set; }

        public decimal VatRatePercentage { get; set; }

        public decimal StandingCharge { get; set; }
    }
}

using System;

namespace MulikaKPLC.DataLayer.Models
{
    public abstract class BaseReading : BaseEntity
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string CurrentIpAddress { get; set; }
        public DateTime DateOfReading { get; set; }
    }
}
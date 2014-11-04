using System;

namespace MulikaKPLC.DataLayer.Models
{
    public abstract class BaseEntity
    {
        public DateTime  DateCreated { get; set; }
        public string  CreatedBy { get; set; }
    }
}
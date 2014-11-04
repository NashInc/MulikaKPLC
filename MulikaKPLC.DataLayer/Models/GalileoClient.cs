using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MulikaKPLC.DataLayer.Models
{
    public class GalileoClient : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid GalileoClientId { get; set; }
        public string DeviceName { get; set; }
        public string SerialNumber { get; set; }

        //Relationships : Navigation Properties
        public virtual ICollection<PowerReading> PowerReadings { get; set; }
        public virtual ICollection<WaterFlowReading> WaterFlowReadings { get; set; }
    }
}
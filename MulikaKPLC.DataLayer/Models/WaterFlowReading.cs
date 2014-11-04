using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MulikaKPLC.DataLayer.Models
{
    public class WaterFlowReading
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid WaterFlowReadingId { get; set; }
    }
}
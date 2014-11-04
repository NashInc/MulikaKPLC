using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MulikaKPLC.DataLayer.Models
{
    public class PowerReading :BaseReading
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PowerReadingId { get; set; }
        public double CurrentValue { get; set; }
        public double PowerInWatts { get; set; }
        public Guid GalileoPowerClientId { get; set; }
        [ForeignKey("GalileoClient")]
        public virtual GalileoClient GalileoClient { get; set; }
    }
}
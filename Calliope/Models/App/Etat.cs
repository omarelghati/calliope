using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Calliope.Models.App
{
    public class Etat
    {
        public int Id { get; set; }
        [Required]
        public byte  etat { get; set; }
        public virtual SavoirFaire SavoireFaire { get; set; }
        public virtual Periode Periode { get; set; }
    }
}
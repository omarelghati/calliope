using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Calliope.Models.App
{
    public class Groupe
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string nomGroupe { get; set; }
        public virtual Niveau Niveau { get; set; }
    }
}
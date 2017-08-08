using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Calliope.Models.App
{
    public class Note
    {
        public int Id { get; set; }
        [Required]
        public int note { get; set; }
        public virtual EvalutiationIndiv EvaluationIndiv { get; set; }
        public virtual SavoirFaire SavoirFaire { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Calliope.Models.App
{
    public class Discipline
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string nomDiscipline { get; set; }
        public virtual EvaluationCollective EvaluationCollective { get; set; }
        public virtual ICollection<Enseignant>  Enseignants { get; set; }
    }
}
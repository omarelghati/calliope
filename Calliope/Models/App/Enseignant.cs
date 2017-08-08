using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calliope.Models.App
{
    public class Enseignant : User
    {
        public virtual ICollection<EvalutiationIndiv> EvaluationIndivs { get; set; }
        public virtual ICollection<Groupe> Groupes { get; set; }
        public virtual ICollection<Discipline> Disciplines { get; set; }
        public Enseignant()
        {
            type = "Enseignant";
        }

    }
}
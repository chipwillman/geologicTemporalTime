using System;
using System.Collections.Generic;
using System.Text;

namespace OwlOntology.Models
{
    public class TemporalReferenceSystem
    {
        public TemporalReferenceSystem()
        {
            Basis = new List<TemporalPosition>();
        }

        public TemporalExtent[] DomainOfValidity { get; set; }
        public string Name { get; set; }

        public List<TemporalPosition> Basis { get; set; }
    }
}

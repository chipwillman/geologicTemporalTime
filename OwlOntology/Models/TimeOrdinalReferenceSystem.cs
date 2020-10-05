using System;
using System.Collections.Generic;
using System.Text;

namespace OwlOntology.Models
{
    public class TimeOrdinalReferenceSystem : TemporalReferenceSystem
    {
        public TimeOrdinalReferenceSystem()
        {
            OrdinalEras = new List<TemporalOrdinalEra>();
            Edges = new List<TemporalEdge>();
        }


        public List<TemporalOrdinalEra> OrdinalEras { get; set; }

        public List<TemporalEdge> Edges { get; set; }
    }
}

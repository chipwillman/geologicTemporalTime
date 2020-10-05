using System;
using System.Collections.Generic;
using System.Text;

namespace OwlOntology.Models
{
    public class TemporalInstant : GeometricPrimitive
    {
        public TemporalPeriod Begin { get; set; }
        public TemporalPeriod End { get; set; }
    }
}

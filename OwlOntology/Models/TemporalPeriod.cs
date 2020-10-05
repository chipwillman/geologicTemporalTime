using System;
using System.Collections.Generic;
using System.Text;

namespace OwlOntology.Models
{
    public class TemporalPeriod : GeometricPrimitive
    {
        public TemporalInstant EndedBy { get; set; }
        public TemporalInstant BegunBy { get; set; }
    }
}

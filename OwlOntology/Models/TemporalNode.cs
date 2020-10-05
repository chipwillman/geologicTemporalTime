using System;
using System.Collections.Generic;
using System.Text;

namespace OwlOntology.Models
{
    public class TemporalNode : TopologicalPrimitive
    {
        public TimeOrdinalEraBoundary End { get; set; }
        public TimeOrdinalEraBoundary Start { get; set; }
    }
}

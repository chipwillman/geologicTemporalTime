using System;
using System.Collections.Generic;
using System.Text;

namespace OwlOntology.Models
{
    public class TimeOrdinalEraBoundary : TemporalEdge
    {
        public TemporalPosition Position { get; set; }
        public Decimal PositionUncertainty { get; set; }
    }
}

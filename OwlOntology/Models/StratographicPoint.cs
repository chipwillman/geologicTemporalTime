using System;
using System.Collections.Generic;
using System.Text;

namespace OwlOntology.Models
{
    public class StratographicPoint : SamplingPoint
    {
        public List<TemporalEdge> AdditionalCorrelationProperty { get; set; }
        public TemporalEdge PrimaryGuidingCriterion { get; set; }
        /// <summary>
        /// Reference Opinion Decision
        /// </summary>
        public string Status { get; set; }
    }
}

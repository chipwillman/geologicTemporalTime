using System;
using System.Collections.Generic;
using System.Text;

namespace OwlOntology.Models
{
    public class StratigraphicSection : SamplingCurve
    {
        public string Accessibility { get; set; }
        public string Conservation { get; set; }
        public string Description { get; set; }
        public string Setting { get; set; }
        public List<TemporalOrdinalEra> GeochronologicalEras { get; set; }
    }
}

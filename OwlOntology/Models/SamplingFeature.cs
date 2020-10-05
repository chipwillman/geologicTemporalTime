using System;
using System.Collections.Generic;
using System.Text;

namespace OwlOntology.Models
{
    public class SamplingFeature
    {
        public List<SamplingFeature> RelatedSamplingFeatures { get; set; }
        public string Role { get; set; }
    }
}

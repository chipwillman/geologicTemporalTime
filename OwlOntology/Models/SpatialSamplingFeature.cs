using System;
using System.Collections.Generic;
using System.Text;

namespace OwlOntology.Models
{
    public class SpatialSamplingFeature : SamplingFeature
    {
        public Decimal[] PositionalAccuracy { get; set; }
        public object Shape { get; set; }
    }

    public class SamplingCurve : SpatialSamplingFeature
    {

    }

    public class SamplingPoint : SpatialSamplingFeature
    {

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OwlOntology.Models
{
    public class TemporalEdge : TopologicalPrimitive
    {
        public TemporalNode Next { get; set; }
        public TemporalNode Previous { get; set; }
    }

    public class PositionUncertainty
    {
        public static decimal Month = 1m / 12m;
        public static decimal Week = 1m / 52m;
        public static decimal Day = 1m / 365.25m;
        public static decimal Hour = 1m / (365.25m * 24);
        public static decimal Minute = 1m / (365.25m * 24 * 60);
        public static decimal Second = 1m / (365.25m * 24 * 60 * 60);
    }

    public class GeochronologicBoundary : TemporalEdge
    {
        public StratigraphicPoint SamplingPoint { get; set; }
    }

    /// <summary>
    /// SF_SamplingPoint
    /// </summary>
    public class StratigraphicPoint 
    {

    }

    public class NumericEraBoundary : TemporalEdge
    {

    }

    public class StandardGlobalNumbericalAge : TemporalEdge
    {

    }
}

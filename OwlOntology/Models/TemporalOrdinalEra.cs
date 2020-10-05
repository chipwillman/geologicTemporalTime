using System;
using System.Collections.Generic;
using System.Text;

namespace OwlOntology.Models
{
    public class TemporalOrdinalEra : TemporalNode
    {
        public TemporalOrdinalEra()
        {
            Children = new List<TemporalOrdinalEra>();
        }

        public string Name { get; set; }
        public List<TemporalOrdinalEra> Children { get; set; }
    }

    public class GeochronologicEra : TemporalOrdinalEra
    {
        public int Rank { get; set; }
        public List<StratigraphicSection> Samples { get; set; }
    }
}

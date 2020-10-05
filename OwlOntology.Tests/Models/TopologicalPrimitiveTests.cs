using System;
using System.Collections.Generic;
using System.Text;
using OwlOntology.Models;

namespace OwlOntology.Tests.Models
{
    public class TopologicalPrimitiveTests
    {
        public void ItHoldsSubclasses()
        {
            var list = new List<TopologicalPrimitive>();
            list.Add(new TemporalEdge());
            list.Add(new TemporalNode());
        }
    }
}

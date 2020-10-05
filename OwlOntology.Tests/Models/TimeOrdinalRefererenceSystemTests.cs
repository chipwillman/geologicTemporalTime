using System;
using System.Collections.Generic;
using System.Text;
using OwlOntology.Models;
using Xunit;

namespace OwlOntology.Tests.Models
{
    public class TimeOrdinalRefererenceSystemTests
    {
        [Fact]
        public void ItHasEdgesAroundTheEras()
        {
            var startEdge = new TimeOrdinalEraBoundary();
            var endEdge = new TimeOrdinalEraBoundary();
            var node = new TemporalOrdinalEra()
            {
                Start = startEdge,
                End = endEdge
            };
            startEdge.Next = node;
            endEdge.Previous = node;

            var referenceSystem = new TimeOrdinalReferenceSystem
            {
                Name = "",
            };
            referenceSystem.OrdinalEras.Add(node);
            referenceSystem.Edges.Add(startEdge);
            referenceSystem.Edges.Add(endEdge);
        }
    }
}

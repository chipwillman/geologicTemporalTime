using System;
using System.Collections.Generic;
using System.Text;
using OwlOntology.Models;
using Xunit;

namespace OwlOntology.Tests.Models
{
    public class TemporalEdgeTests
    {
        [Fact]
        public void TestTermination()
        {
            var edge = new TemporalEdge
            {
                Previous = new TemporalNode()
            };

            Assert.NotNull(edge.Previous);
        }

        [Fact]
        public void TestInitiation()
        {
            var edge = new TemporalEdge
            {
                Next = new TemporalNode()
            };

            Assert.NotNull(edge.Next);
        }
    }
}

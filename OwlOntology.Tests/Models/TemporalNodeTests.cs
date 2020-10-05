using System;
using System.Collections.Generic;
using System.Text;
using OwlOntology.Models;
using Xunit;

namespace OwlOntology.Tests.Models
{
    public class TemporalNodeTests
    {
        [Fact]
        public void TestTermination()
        {
            var node = new TemporalNode
            {
                End = new TimeOrdinalEraBoundary()
            };

            Assert.NotNull(node.End);
        }

        [Fact]
        public void TestInitiation()
        {
            var node = new TemporalNode
            {
                Start = new TimeOrdinalEraBoundary()
            };

            Assert.NotNull(node.Start);
        }
    }
}

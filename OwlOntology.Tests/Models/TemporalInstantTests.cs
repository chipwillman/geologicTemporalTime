using System;
using System.Collections.Generic;
using System.Text;
using OwlOntology.Models;
using Xunit;

namespace OwlOntology.Tests.Models
{
    public class TemporalInstantTests
    {
        [Fact]
        public void IsHasABeginnging()
        {
            var period = new TemporalInstant
            {
                Begin = new TemporalPeriod()
            };

            Assert.NotNull(period.Begin);
        }

        [Fact]
        public void IsHasAnEnding()
        {
            var period = new TemporalInstant
            {
                End = new TemporalPeriod()
            };

            Assert.NotNull(period.End);
        }

    }
}

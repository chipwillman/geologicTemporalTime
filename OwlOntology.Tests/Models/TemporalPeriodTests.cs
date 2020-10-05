using System;
using System.Collections.Generic;
using System.Text;
using OwlOntology.Models;
using Xunit;

namespace OwlOntology.Tests.Models
{
    public class TemporalPeriodTests
    {
        [Fact]
        public void IsHasABeginnging()
        {
            var period = new TemporalPeriod
            {
                BegunBy = new TemporalInstant()
            };

            Assert.NotNull(period.BegunBy);
        }

        [Fact]
        public void IsHasAnEnding()
        {
            var period = new TemporalPeriod
            {
                EndedBy = new TemporalInstant()
            };

            Assert.NotNull(period.EndedBy);
        }
    }
}

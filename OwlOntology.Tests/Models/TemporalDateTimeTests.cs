using System;
using System.Collections.Generic;
using System.Text;
using OwlOntology.Models;
using Xunit;

namespace OwlOntology.Tests.Models
{
    public class TemporalDateTimeTests
    {
        [Fact]
        public void IsCanHaveBeginningDatesMillionsOfYearsAgo()
        {
            var beginingOfTheQuaternary = new TemporalDateTime()
            {
                YBP = 2600000.0m
            };

            Assert.Equal(2600000m, beginingOfTheQuaternary.YBP);
        }

        [Fact]
        public void IsCanHaveEndingsThatAreBillionsOfYearsAgo()
        {
            var beginningOfSolSystem = new TemporalDateTime()
            {
                YBP = 4500000000.0m
            };

            Assert.Equal(4500000000.0m, beginningOfSolSystem.YBP);
        }
    }
}

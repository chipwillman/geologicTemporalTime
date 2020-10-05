using System;
using System.Collections.Generic;
using System.Text;
using OwlOntology.Models;
using Xunit;

namespace OwlOntology.Tests.Models
{
    public class TemporalPositionTests
    {
        [Fact]
        public void IsMayHaveAnIndeterminatePosition()
        {
            var positionWith = new TemporalPosition
            {
                IndeterminatePosition = new Coordinate()
            };

            var positionWithout = new TemporalPosition
            {
                IndeterminatePosition = null
            };
        }
    }
}

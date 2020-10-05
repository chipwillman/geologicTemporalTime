using System;
using System.Collections.Generic;
using System.Text;
using OwlOntology.Models;
using Xunit;

namespace OwlOntology.Tests.Models
{
    public class GeometricPrimitiveTests
    {
        [Fact]
        public void IsHoldSubclasses()
        {
            var list = new List<GeometricPrimitive>();
            list.Add(new TemporalPeriod());
            list.Add(new TemporalInstant());
        }
    }
}

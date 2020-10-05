using System;
using System.Collections.Generic;
using System.Text;
using OwlOntology.Models;
using Xunit;

namespace OwlOntology.Tests.Models
{
    public class TemporalReferenceSystemTests
    {
        [Fact]
        public void ItHasHasADomainOfValidity()
        {
            var referenceSystem = new TemporalReferenceSystem()
            {
                DomainOfValidity = new TemporalExtent[] { new TemporalExtent(), new TemporalExtent() },
                Name = "Test Reference System with two extents"
            };

            Assert.NotEmpty(referenceSystem.DomainOfValidity);
        }

        [Fact]
        public void ItHasAName()
        {
            var referenceSystem = new TemporalReferenceSystem()
            {
                Name = "Test Reference Name"
            };

            Assert.Equal("Test Reference Name", referenceSystem.Name);
        }

        [Fact]
        public void ItHasABasisForItsSystem()
        {
            var referenceSystem = new TemporalReferenceSystem
            {
                Name = "Reference with a basis"
            };
            referenceSystem.Basis.Add(new TemporalPosition());
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using OwlOntology.Models;
using Xunit;

namespace OwlOntology.Tests.Models
{
    public class TemporalOrdinalEraTests
    {
        [Fact]
        public void IsCanRepresentTheQuaternaryPeriod()
        {
            var currentYBP = -(DateTime.UtcNow.Year - 1950);
            var quaternary = new TemporalOrdinalEra()
            {
                Name = "Quaternary",
                Start = new TimeOrdinalEraBoundary { Position = new TemporalDateTime { YBP = 2600000.0m } },
                End = new TimeOrdinalEraBoundary { Position = new TemporalDateTime { YBP = currentYBP } }
            };
            Assert.Equal("Quaternary", quaternary.Name);
            Assert.True(quaternary.Start.Position.YBP > quaternary.End.Position.YBP);
        }

        [Fact]
        public void IsCanRepresentTheNorthgrippianAge()
        {
            var quaternary = new TemporalOrdinalEra()
            {
                Name = "Northgrippian",
                Start = new TimeOrdinalEraBoundary
                {
                    Position = new TemporalDateTime { YBP = 8200.0m }
                },
                End = new TimeOrdinalEraBoundary
                {
                    Position = new TemporalDateTime { YBP = 4200.0m }
                }
            };
            Assert.Equal("Northgrippian", quaternary.Name);
            Assert.True(quaternary.Start.Position.YBP > quaternary.End.Position.YBP);
        }

        [Fact]
        public void IsCanHaveEpochsComposedOfAges()
        {
            var currentYBP = -(DateTime.UtcNow.Year - 1950);
            var holocene = new TemporalOrdinalEra()
            {
                Name = "Holocene",
                Start = new TimeOrdinalEraBoundary
                {
                    Position = new TemporalDateTime { YBP = 11650.0m }
                },
                End = new TimeOrdinalEraBoundary
                {
                    Position = new TemporalDateTime { YBP = currentYBP }
                }
            };

            var meghalayan = new TemporalOrdinalEra
            {
                Name = "Meghalayan",
                Start = new TimeOrdinalEraBoundary
                {
                    Position = new TemporalDateTime { YBP = 4200.0m }
                },
                End = new TimeOrdinalEraBoundary
                {
                    Position = new TemporalDateTime { YBP = currentYBP }
                }
            };

            var northgrippian = new TemporalOrdinalEra
            {
                Name = "Northgrippian",
                Start = new TimeOrdinalEraBoundary
                {
                    Position = new TemporalDateTime { YBP = 8200 }
                },
                End = new TimeOrdinalEraBoundary
                {
                    Position = new TemporalDateTime { YBP = 4200.0m }
                }
            };

            var greenlandian = new TemporalOrdinalEra
            {
                Name = "Greenlandian",
                Start = new TimeOrdinalEraBoundary
                {
                    Position = new TemporalDateTime { YBP = 11650.0m }
                },
                End = new TimeOrdinalEraBoundary
                {
                    Position = new TemporalDateTime { YBP = 8200.0m }
                }
            };

            holocene.Children.AddRange(new [] { meghalayan, northgrippian, greenlandian });

            Assert.Equal(holocene.Start.Position.YBP, greenlandian.Start.Position.YBP);
            Assert.Equal(holocene.End.Position.YBP, meghalayan.End.Position.YBP);
        }

        [Fact]
        public void GeochronologicEraHasARank()
        {
            var era = new GeochronologicEra()
            {
                Rank = 2
            };

            Assert.Equal(2, era.Rank);
        }
    }
}

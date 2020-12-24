using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenDataWrapper.Domains.Mobility.Enums;
using OpenDataWrapper.Enums;
using System;

namespace OpenDataWrapper.Tests
{
    [TestClass]
    public class RequestBuilder_Get
    {
        [TestMethod]
        public void Get()
        {
            var requestBuilder = new RequestBuilder();

            var from = DateTime.Now.AddDays(-1);
            var to = DateTime.Now.AddDays(1);

            requestBuilder
                .UseRepresentationType(RepresentationType.Flat)
                .UseStationTypes(StationType.Traffic.EnvironmentStation)
                .UseDataTypes(DataType.EnvironmentStation.All)
                .From(from)
                .To(to)
                .WithOffset(10)
                .WithLimit(100);

            var result = requestBuilder.Get();

            Assert.IsNotNull(result);
            Assert.AreEqual(result.RepresentationType, "flat");
            CollectionAssert.AreEqual(result.StationTypes, new string[] { "EnvironmentStation" });
            CollectionAssert.AreEqual(result.DataTypes, new string[] { "*" });
            //Assert.AreEqual(result.From, from);
            //Assert.AreEqual(result.To, to);
            Assert.AreEqual(result.Offset, 10);
            Assert.AreEqual(result.Limit, 100);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenDataWrapper.Domains.Mobility;
using OpenDataWrapper.Domains.Mobility.Dto;
using OpenDataWrapper.Domains.Mobility.Dto.Metadata;
using OpenDataWrapper.Domains.Mobility.Enums;
using OpenDataWrapper.Enums;

namespace OpenDataWrapper.Tests
{
    [TestClass]
    public class MobilityService_Get
    {
        [TestMethod]
        public void Get_Bicycle_Station_Data()
        {
            var mobilityService = new MobilityService();
            var result = mobilityService.Get<MobilityStationTypeResponse<BicycleStationMetadata, BicycleMetadata>>(RequestBase.Create(RepresentationType.Flat, new string[] { StationType.Mobility.Bicycle })).Result;

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Offset, 0);
            Assert.AreEqual(result.Limit, 200);
            Assert.IsNotNull(result.Data);
        }

        [TestMethod]
        public void Get_ECharging_Station_Data()
        {
            var mobilityService = new MobilityService();
            var result = mobilityService.Get<MobilityStationTypeResponse<ChargingStation>>(RequestBase.Create(RepresentationType.Flat, new string[] { StationType.Mobility.EChargingStation })).Result;

            Assert.IsTrue(result.Data.Count > 0);
        }

        [TestMethod]
        public void Get_ECharging_Station_And_ECharging_Plug_Data()
        {
            var mobilityService = new MobilityService();
            var result = mobilityService.Get<MobilityStationTypeResponse<ChargingStation>>(RequestBase.Create(RepresentationType.Flat, new string[] { StationType.Mobility.EChargingStation, StationType.Mobility.ECharingPlug })).Result;

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Offset, 0);
            Assert.AreEqual(result.Limit, 200);
            Assert.IsNotNull(result.Data);
        }

        [TestMethod]
        public void Get_Environment_Station_Measurement_Data()
        {
            var mobilityService = new MobilityService();
            var result = mobilityService.Get<MobilityDataTypeResponse<NullMetadata>>(
                RequestBase.Create(
                    RepresentationType.Flat,
                    new string[] { StationType.Traffic.EnvironmentStation },
                    new string[] { DataType.EnvironmentStation.All },
                    null,
                    new WhereClause(new OrElse(
                        new FilterTriple("scode", OperatorType.Eq, "BZ5"),
                        new FilterTriple("scode", OperatorType.Eq, "BZ6"))
                    )
                )).Result;

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Offset, 0);
            Assert.AreEqual(result.Limit, 200);
            Assert.IsNotNull(result.Data);
        }
    }
}

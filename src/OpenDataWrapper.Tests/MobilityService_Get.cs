using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenDataWrapper.Domains.Mobility;
using OpenDataWrapper.Domains.Mobility.Dto;
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
            var result = mobilityService.Get<MobilityResponse<BicycleStation, Bicycle>>(RequestBase.Create(RepresentationType.Flat, new string[] { StationType.Bicycle })).Result;

            Assert.IsTrue(result.Data.Count > 0);
        }

        [TestMethod]
        public void Get_ECharging_Station_Data()
        {
            var mobilityService = new MobilityService();
            var result = mobilityService.Get<MobilityResponse<ChargingStation>>(RequestBase.Create(RepresentationType.Flat, new string[] { StationType.EChargingStation })).Result;

            Assert.IsTrue(result.Data.Count > 0);
        }

        [TestMethod]
        public void Get_ECharging_Station_And_ECharging_Plug_Data()
        {
            var mobilityService = new MobilityService();
            var result = mobilityService.Get<MobilityResponse<ChargingStation>>(RequestBase.Create(RepresentationType.Flat, new string[] { StationType.EChargingStation, StationType.ECharingPlug })).Result;
            
            Assert.IsTrue(result.Data.Count > 0);
        }
    }
}

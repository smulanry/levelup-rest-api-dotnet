using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LevelUpRestApi.Tests
{
    [TestClass]
    public class LocationsTests
    {
        [TestMethod]
        public void Can_Get_All_Locations()
        {
            var results = Location.All(TestUtils.CreateValidAuthorizationToken());
            Assert.IsTrue(results.Any(), "There should be at least 1 location returned.");
        }

        [TestMethod]
        public void Can_Find_Locations_By_Application_Id()
        {
            var results = Location.FindByApplicationId(TestUtils.CreateValidAuthorizationToken(), 1);
            Assert.IsNotNull(results, "There should be a location returned.");
            Assert.IsTrue(results.Any(), "There should be at least 1 location returned.");
        }

        [TestMethod]
        public void Can_Get_Location()
        {
            var results = Location.Get(TestUtils.CreateValidAuthorizationToken(), 25);
            Assert.IsNotNull(results, "There should be a location returned.");
            Assert.IsNotNull(results.MerchantName, "There should be a name");
        }


    }
}

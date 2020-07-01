using Microsoft.VisualStudio.TestTools.UnitTesting;
using MortgageCalculatorBackend.Accessors.Shared;

namespace MortgageCalculatorBackend.Tests.AccessorTests
{
    [TestClass]
    public class DTOMapperTests
    {
        [TestMethod]
        [TestCategory("Accessor Tests")]
        public void DTOMapper_IsDTOMapperConfigValid()
        {
            DTOMapper.Configuration.AssertConfigurationIsValid();
        }
    }
}

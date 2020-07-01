using Microsoft.VisualStudio.TestTools.UnitTesting;
using MortgageCalculatorBackend.Engines.Shared;

namespace MortgageCalculatorBackend.Tests.EngineTests
{
    [TestClass]
    public class DTOMapperTests
    {
        [TestMethod]
        [TestCategory("Engine Tests")]
        public void DTOMapper_IsDTOMApperConfigValid()
        {
            DTOMapper.Configuration.AssertConfigurationIsValid();
        }
    }
}

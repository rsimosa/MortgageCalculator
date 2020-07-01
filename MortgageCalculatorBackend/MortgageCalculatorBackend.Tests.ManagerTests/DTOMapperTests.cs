using Microsoft.VisualStudio.TestTools.UnitTesting;
using MortgageCalculatorBackend.Managers.Shared;

namespace MortgageCalculatorBackend.Tests.ManagerTests
{
    [TestClass]
    public class DTOMapperTests
    {
        [TestMethod]
        [TestCategory("Manager Tests")]
        public void DTOMapper_IsDTOMApperConfigValid()
        {
            DTOMapper.Configuration.AssertConfigurationIsValid();
        }
    }
}

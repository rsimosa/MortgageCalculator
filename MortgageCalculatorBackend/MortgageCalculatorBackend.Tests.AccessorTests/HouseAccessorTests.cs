using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MortgageCalculatorBackend.Accessors;
using MortgageCalculatorBackend.Common.Contracts;
using MortgageCalculatorBackend.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageCalculatorBackend.Tests.AccessorTests
{
    [TestClass] 
    public class HouseAccessorTests : TestAccessorBase
    {
        AmbientContext _context = new AmbientContext();

        UtilityFactory UtilityFactory()
        {
            return new UtilityFactory(_context);
        }

        AccessorFactory AccessorFactory()
        {
            var factory = new AccessorFactory(_context, UtilityFactory());
            return factory;
        }

        [TestMethod]
        public void HouseListTest()
        {
            var houseAccessor = AccessorFactory().CreateAccessor<IHouseAccessor>();
            var List = houseAccessor.HouseList();
            Assert.IsTrue(List.Length > 0);
        }

    }
}

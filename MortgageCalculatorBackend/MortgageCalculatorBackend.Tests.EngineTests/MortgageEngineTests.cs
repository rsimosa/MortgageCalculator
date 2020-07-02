using Microsoft.VisualStudio.TestTools.UnitTesting;
using MortgageCalculatorBackend.Accessors;
using MortgageCalculatorBackend.Common.Contracts;
using MortgageCalculatorBackend.Engines;
using MortgageCalculatorBackend.Engines.Shared;
using MortgageCalculatorBackend.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageCalculatorBackend.Tests.EngineTests
{
    [TestClass]
    public class MortgageEngineTests
    {
        IMortgageEngine mortgageEngine;

        [TestInitialize]
        public void EngineTestInit()
        {
            var context = new AmbientContext();
            var utilityFactory = new UtilityFactory(context);
            var accessorFactory = new AccessorFactory(context, utilityFactory);

            var engineFactory = new EngineFactory(context, accessorFactory, utilityFactory);
            mortgageEngine = engineFactory.CreateEngine<IMortgageEngine>();
        }

        [TestMethod]
        public void CalculateMortgage_Tests()
        {
            var result = mortgageEngine.CalculateMortgage(100000,0.05,40);
            Assert.AreEqual(5827.82m, result);
        }  
    }
}

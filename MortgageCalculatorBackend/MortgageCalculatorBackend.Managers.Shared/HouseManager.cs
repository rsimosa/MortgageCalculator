using MortgageCalculatorBackend.Accessors;
using MortgageCalculatorBackend.Contracts.Client;
using MortgageCalculatorBackend.Engines.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageCalculatorBackend.Managers.Shared
{
    public class HouseManager : ManagerBase, IHouseManager
    {

        public decimal CalculateMortgage(double L, double R, int N)
        {

            var engine = EngineFactory.CreateEngine<IMortgageEngine>();
            return engine.CalculateMortgage(L, R, N);

        }

        public decimal[] CalculateMultipleMortgage()
        {
            var accessor = AccessorFactory.CreateAccessor<IHouseAccessor>();
            var list = accessor.HouseList();

            var result = new List<decimal>();

            foreach(var item in list)
            {
                var engine = EngineFactory.CreateEngine<IMortgageEngine>();
                result.Add(engine.CalculateMortgage((double)item, 0.05, 40));
            }

            return result.ToArray();
        }
    }
}

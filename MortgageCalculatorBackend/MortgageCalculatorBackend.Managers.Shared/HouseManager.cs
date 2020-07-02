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
    }
}

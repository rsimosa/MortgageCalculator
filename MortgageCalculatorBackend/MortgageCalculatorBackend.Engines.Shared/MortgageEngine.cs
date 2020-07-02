using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageCalculatorBackend.Engines.Shared
{
    public class MortgageEngine : EngineBase, IMortgageEngine
    {   
        public decimal CalculateMortgage(double L, double R, int N)
        {
            //L = Loan Amount
            //R = Interest Rate
            //N = Mumber of Payments      
                        
            return decimal.Round(Convert.ToDecimal((L * R) / (1 - (Math.Pow(1 / (1 + R), N)))),2,MidpointRounding.AwayFromZero);
        }
    }
}

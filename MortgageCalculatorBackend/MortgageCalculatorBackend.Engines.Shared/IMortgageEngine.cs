using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageCalculatorBackend.Engines.Shared
{
    public interface IMortgageEngine
    {
        public decimal CalculateMortgage(double L, double R, int N);
    }
}

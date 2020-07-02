using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageCalculatorBackend.Contracts.Client
{
    public interface IHouseManager
    {
        decimal CalculateMortgage(double L, double R, int N);
    }
}

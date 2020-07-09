using MortgageCalculatorBackend.Accessors.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageCalculatorBackend.Accessors
{
    public class HouseAccessor : AccessorBase, IHouseAccessor    {

        public decimal[] HouseList()
        {
            return new decimal[] {100000.00m, 200000.00m, 300000.00m };

        }
    }
}

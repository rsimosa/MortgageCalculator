using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageCalculatorBackend.Accessors
{
    public interface IHouseAccessor
    {
        decimal[] HouseList();
    }
}

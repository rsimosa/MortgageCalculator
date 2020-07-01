using MortgageCalculatorBackend.Accessors;
using MortgageCalculatorBackend.Common.Shared;
using MortgageCalculatorBackend.Utilities;

namespace MortgageCalculatorBackend.Engines.Shared
{
    public abstract class EngineBase : ServiceContractBase
    {
        public AccessorFactory AccessorFactory { get; set; }
        public UtilityFactory UtilityFactory { get; set; }

        protected EngineBase()
        {

        }
    }
}

using MortgageCalculatorBackend.Accessors;
using MortgageCalculatorBackend.Common.Shared;
using MortgageCalculatorBackend.Engines;
using MortgageCalculatorBackend.Utilities;

namespace MortgageCalculatorBackend.Managers.Shared
{
    public abstract class ManagerBase : ServiceContractBase
    {
        public EngineFactory EngineFactory { get; set; }
        public AccessorFactory AccessorFactory { get; set; }
        public UtilityFactory UtilityFactory { get; set; }

        protected ManagerBase()
        {

        }
    }
}

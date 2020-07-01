using Microsoft.Extensions.Configuration;
using MortgageCalculatorBackend.Common.Shared;
using MortgageCalculatorBackend.Utilities;

namespace MortgageCalculatorBackend.Accessors.Shared
{
    public abstract class AccessorBase : ServiceContractBase
    {
        public UtilityFactory UtilityFactory { get; set; }

        protected string DatabaseConnectionString
        {
            get
            {
                var builder = new ConfigurationBuilder()
                    .AddEnvironmentVariables();

                var configuration = builder.Build();

                var db = configuration["REPLACE_WITH_CONNECTIONSTRING"];

                return db;
            }
        }
    }
}

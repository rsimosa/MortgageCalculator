using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using MortgageCalculatorBackend.Managers;
using MortgageCalculatorBackend.Contracts.Client;
using MortgageCalculatorBackend.Common.Contracts;
using System.Linq;
using System.Web;

namespace MortgageCalculatorBackend.AzureFunction
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            // ?L = 123123 & R = 1123 & N = 123123

            var query = HttpUtility.ParseQueryString(req.QueryString.ToString());

            var L = Convert.ToDouble(query.Get("L"));
            var R = Convert.ToDouble(query.Get("R"));
            var N = Convert.ToInt32(query.Get("N"));

            var response = CalculateMortgage(L, R, N);

            return new OkObjectResult(response);

        }

        static ManagerFactory CreateFactory()
        {
            var context = new AmbientContext();
            var managerFactory = new ManagerFactory(context);

            return managerFactory;
        }

        static IHouseManager CreateManager()
        {
            var managerFactory = CreateFactory();
            var manager = managerFactory.CreateManager<IHouseManager>();
            return manager;
        }

        static decimal CalculateMortgage(double L, double R, int N)
        {
            return CreateManager().CalculateMortgage(L, R, N);
        }

    }
}

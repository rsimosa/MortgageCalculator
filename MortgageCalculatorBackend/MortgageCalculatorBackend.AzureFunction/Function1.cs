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


            //var query = req.QueryString.ToString().ToCharArray();

            //for (int i = 0; i < query.Count(); i++)
            //{ 
            //    if (query[i].Equals("L"))
            //    {

            //    }
            //}
            

            var response = CalculateMortgage(100000, 0.05, 40);

            return new OkObjectResult(response.ToString());

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

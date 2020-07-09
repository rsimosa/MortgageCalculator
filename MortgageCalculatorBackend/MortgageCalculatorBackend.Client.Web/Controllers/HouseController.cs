using Microsoft.AspNetCore.Mvc;
using MortgageCalculatorBackend.Common.Contracts;
using MortgageCalculatorBackend.Contracts.Client;
using MortgageCalculatorBackend.Managers;

namespace MortgageCalculatorBackend.Client.Web.Controllers
{
    public class HouseController : Controller
    {
        private ManagerFactory CreateFactory()
        {
            var context = new AmbientContext();
            var managerFactory = new ManagerFactory(context);

            return managerFactory;
        }

        private IHouseManager CreateManager()
        {
            var managerFactory = CreateFactory();
            var manager = managerFactory.CreateManager<IHouseManager>();
            return manager;
        }

        public decimal CalculateMortgage(double L, double R, int N)
        {
            return CreateManager().CalculateMortgage(L, R, N);
        }

        public decimal[] CalculateMultipleMortgage()
        {
            return CreateManager().CalculateMultipleMortgage();
        }
    }
}

﻿using System;
using MortgageCalculatorBackend.Accessors;
using MortgageCalculatorBackend.Common.Contracts;
using MortgageCalculatorBackend.Common.Shared;
using MortgageCalculatorBackend.Contracts.Client;
using MortgageCalculatorBackend.Engines;
using MortgageCalculatorBackend.Managers.Shared;
using MortgageCalculatorBackend.Utilities;

namespace MortgageCalculatorBackend.Managers
{
    public class ManagerFactory : FactoryBase
    {
        public ManagerFactory(AmbientContext context) : base(context)
        {
            //AddType<IAdminFulfillmentManager>(typeof(OrderManager));
            AddType<IHouseManager>(typeof(HouseManager));
        }

        public T CreateManager<T>() where T : class
        {
            T result = CreateManager<T>(null, null, null);
            return result;
        }

        public T CreateManager<T>(
            EngineFactory engineFactory, AccessorFactory accessorFactory, UtilityFactory utilityFactory) where T : class
        {
            if (Context == null)
            {
                throw new InvalidOperationException("Context cannot be null");
            }

            if (utilityFactory == null)
            {
                utilityFactory = new UtilityFactory(Context);
            }

            if (accessorFactory == null)
            {
                accessorFactory = new AccessorFactory(Context, utilityFactory);
            }

            if (engineFactory == null)
            {
                engineFactory = new EngineFactory(Context, accessorFactory, utilityFactory);
            }

            T result = GetInstanceForType<T>();

            if (result is ManagerBase)
            {
                (result as ManagerBase).Context = Context;
                (result as ManagerBase).EngineFactory = engineFactory;
                (result as ManagerBase).AccessorFactory = accessorFactory;
                (result as ManagerBase).UtilityFactory = utilityFactory;
            }
            else
            {
                // mocking of the manager factory is not supported so every result should implement ManagerBase
                throw new InvalidOperationException($"{typeof(T).Name} does not implement ManagerBase");
            }

            return result;
        }
    }
}

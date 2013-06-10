using StructureMap;
using System;
using vSol.CQRS.CommandHandlers;
using vSol.CQRS.Commands;
using vSol.CQRS.Messaging;
using vSol.CQRS.Utils;

namespace StructureMapPoc
{
    public sealed class ServiceLocator
    {
        private static ICommandBus _commandBus;
        private static bool _isInitialized;
        private static readonly object _lockThis = new object();

        static ServiceLocator()
        {
            if (!_isInitialized)
            {
                lock (_lockThis)
                {
                    ContainerBootstrapper.BootstrapStructureMap();
                    _commandBus = ObjectFactory.GetInstance<ICommandBus>();
                    _isInitialized = true;
                }
            }
        }

        public static ICommandBus CommandBus
        {
            get { return _commandBus; }
        }
    }

    static class ContainerBootstrapper
    {
        public static void BootstrapStructureMap()
        {
            ObjectFactory.Initialize(x =>
            {
                //x.For<ICommandBus>().Use<CommandBus>();
                //x.For<ICommandHandlerFactory>().Use<CommandHandlerFactory>();

                x.Scan(scanner =>
                {
                    //scanner.TheCallingAssembly();
                    scanner.AssembliesFromApplicationBaseDirectory();
                    scanner.WithDefaultConventions();
                    scanner.AssemblyContainingType(typeof(ICommandHandler<>));
                    //scanner.AddAllTypesOf(typeof(ICommandHandler<>));
                });
            });
        }
    }
}

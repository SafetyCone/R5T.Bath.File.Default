using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy;


namespace R5T.Bath.File.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DefaultHumanOutputFileNameProvider"/> implementation of <see cref="IHumanOutputFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultHumanOutputFileNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<IHumanOutputFileNameProvider, DefaultHumanOutputFileNameProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DefaultHumanOutputFileNameProvider"/> implementation of <see cref="IHumanOutputFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IHumanOutputFileNameProvider> AddDefaultHumanOutputFileNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IHumanOutputFileNameProvider>.New(() => services.AddDefaultHumanOutputFileNameProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="DefaultHumanOutputFilePathProvider"/> implementation of <see cref="IHumanOutputFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultHumanOutputFilePathProvider(this IServiceCollection services,
            IServiceAction<IHumanOutputFileDirectoryPathProvider> addHumanOutputFileDirectoryPathProvider,
            IServiceAction<IHumanOutputFileNameProvider> addHumanFileNameProvider,
            IServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            services
                .AddSingleton<IHumanOutputFilePathProvider, DefaultHumanOutputFilePathProvider>()
                .RunServiceAction(addHumanOutputFileDirectoryPathProvider)
                .RunServiceAction(addHumanFileNameProvider)
                .RunServiceAction(addStringlyTypedPathOperator)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DefaultHumanOutputFilePathProvider"/> implementation of <see cref="IHumanOutputFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IHumanOutputFilePathProvider> AddDefaultHumanOutputFilePathProviderAction(this IServiceCollection services,
            IServiceAction<IHumanOutputFileDirectoryPathProvider> addHumanOutputFileDirectoryPathProvider,
            IServiceAction<IHumanOutputFileNameProvider> addHumanFileNameProvider,
            IServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            var serviceAction = ServiceAction<IHumanOutputFilePathProvider>.New(() => services.AddDefaultHumanOutputFilePathProvider(
                addHumanOutputFileDirectoryPathProvider,
                addHumanFileNameProvider,
                addStringlyTypedPathOperator));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="SpecifiedHumanOutputFileDirectoryPathProvider"/> implementation of <see cref="IHumanOutputFileDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// Uses the provided <paramref name="humanOutputFileDirectoryPath"/> value.
        /// </summary>
        public static IServiceCollection AddSpecifiedHumanOutputFileDirectoryPathProvider(this IServiceCollection services, string humanOutputFileDirectoryPath)
        {
            services.AddSingleton<IHumanOutputFileDirectoryPathProvider>(serviceProvider =>
            {
                var humanOutputFileDirectoryPathProvider = new SpecifiedHumanOutputFileDirectoryPathProvider(humanOutputFileDirectoryPath);
                return humanOutputFileDirectoryPathProvider;
            });

            return services;
        }

        /// <summary>
        /// Adds the <see cref="SpecifiedHumanOutputFileDirectoryPathProvider"/> implementation of <see cref="IHumanOutputFileDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// Uses the provided <paramref name="humanOutputFileDirectoryPath"/> value.
        /// </summary>
        public static IServiceAction<IHumanOutputFileDirectoryPathProvider> AddSpecifiedHumanOutputFileDirectoryPathProviderAction(this IServiceCollection services, string humanOutputFileDirectoryPath)
        {
            var serviceAction = new ServiceAction<IHumanOutputFileDirectoryPathProvider>(() => services.AddSpecifiedHumanOutputFileDirectoryPathProvider(humanOutputFileDirectoryPath));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="SpecifiedHumanOutputFileNameProvider"/> implementation of <see cref="IHumanOutputFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// Uses the provided <paramref name="humanOutputFileName"/> value.
        /// </summary>
        public static IServiceCollection AddSpecifiedHumanOutputFileNameProvider(this IServiceCollection services, string humanOutputFileName)
        {
            services.AddSingleton<IHumanOutputFileNameProvider>(serviceProvider =>
            {
                var humanOutputFileNameProvider = new SpecifiedHumanOutputFileNameProvider(humanOutputFileName);
                return humanOutputFileNameProvider;
            });

            return services;
        }

        /// <summary>
        /// Adds the <see cref="SpecifiedHumanOutputFileNameProvider"/> implementation of <see cref="IHumanOutputFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// Uses the provided <paramref name="humanOutputFileName"/> value.
        /// </summary>
        public static IServiceAction<IHumanOutputFileNameProvider> AddSpecifiedHumanOutputFileNameProviderAction(this IServiceCollection services, string humanOutputFileName)
        {
            var serviceAction = ServiceAction<IHumanOutputFileNameProvider>.New(() => services.AddSpecifiedHumanOutputFileNameProvider(humanOutputFileName));
            return serviceAction;
        }
    }
}

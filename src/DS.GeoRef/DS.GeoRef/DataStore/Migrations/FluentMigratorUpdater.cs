using DS.GeoRef.DataStore.Migrations.Repository;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DS.GeoRef.DataStore.Migrations
{
    /// <summary>
    /// FluentMigrator Updater v1.0 (2022-03-20)
    /// </summary>
    /// <remarks>
    /// TODO: Use AppSetting to select SQL Engine (not only SqlServer)
    /// </remarks>
    public class FluentMigratorUpdater
    {
        private readonly string connectionString;

        public FluentMigratorUpdater(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Run()
        {
            var fluentMigrationServiceProvider = CreateFluentMigrationServiceProvider(this.connectionString);

            // Put the database update into a scope to ensure
            // that all resources will be disposed.
            using (var scope = fluentMigrationServiceProvider.CreateScope())
            {
                UpdateDatabase(scope.ServiceProvider);
            }
        }

        /// <summary>
        /// Update the database
        /// </sumamry>
        private void UpdateDatabase(IServiceProvider serviceProvider)
        {
            // Instantiate the runner
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();

            // Execute the migrations
            runner.MigrateUp();
            //runner.MigrateDown(0);
        }

        /// <summary>
        /// Configure the dependency injection services
        /// </sumamry>
        private IServiceProvider CreateFluentMigrationServiceProvider(string connectionString)
        {
            return new ServiceCollection()
                // Add common FluentMigrator services
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddSqlServer()
                    // Set the connection string
                    .WithGlobalConnectionString(connectionString)
                    // Define the assembly containing the migrations
                    .ScanIn(typeof(FluentMigratorRepository).Assembly).For.Migrations())
                // Enable logging to console in the FluentMigrator way
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                // Build the service provider
                .BuildServiceProvider(false);
        }
    }
}

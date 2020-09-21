using System;
using CatFactory.AspNetCore;
using CatFactory.EfCore;
using CatFactory.SqlServer;

namespace Auto.Test {
    class Program {
        static void Main(string[] args) {
            B();
        }
        static void A() {
            // Import database
            var factory = new SqlServerDatabaseFactory() {
                ConnectionString = "server=.;database=auto_news;integrated security=yes;"

            };
            var database = factory.Import();
            // Create instance of Entity Framework Core Project
            var entityFrameworkProject = new EntityFrameworkCoreProject() {
                Name = "OnLineStore.Core",
                Database = database,
                OutputDirectory = @"./"
            };
            // Apply settings for project
            entityFrameworkProject.GlobalSelection(settings => {
                settings.ForceOverwrite = true;
                settings.ConcurrencyToken = "Timestamp";
                settings.AuditEntity = new AuditEntity {
                    CreationUserColumnName = "CreationUser",
                    CreationDateTimeColumnName = "CreationDateTime",
                    LastUpdateUserColumnName = "LastUpdateUser",
                    LastUpdateDateTimeColumnName = "LastUpdateDateTime"
                };
            });

            entityFrameworkProject.Select("dbo.Orders", settings => settings.EntitiesWithDataContracts = true);

            // Build features for project, group all entities by schema into a feature
            entityFrameworkProject.BuildFeatures();

            // Scaffolding =^^=
            entityFrameworkProject
                .ScaffoldEntityLayer()
                .ScaffoldDataLayer();

            var aspNetCoreProject = entityFrameworkProject
                .CreateAspNetCoreProject("Northwind.WebAPI", @"./", entityFrameworkProject.Database);

            aspNetCoreProject.GlobalSelection(settings => settings.ForceOverwrite = true);

            aspNetCoreProject.ScaffoldAspNetCore();

        }
        static void B() {
            // Import database
            var factory = new SqlServerDatabaseFactory() {
                ConnectionString = "server=.;database=auto_news;integrated security=yes;"

            };
            var database = factory.Import();
            // Create instance of Entity Framework Core Project
            var entityFrameworkProject = new EntityFrameworkCoreProject() {
                Name = "OnLineStore.Core",
                Database = database,
                OutputDirectory = @"./"
            };
            // Apply settings for project
            entityFrameworkProject.GlobalSelection(settings => {
                settings.ForceOverwrite = true;
                settings.ConcurrencyToken = "Timestamp";
                settings.ConcurrencyToken = "123";
                settings.Validate();
                settings.EnableDataBindings = true;
                settings.AuditEntity = new AuditEntity {
                    CreationUserColumnName = "CreationUser",
                    CreationDateTimeColumnName = "CreationDateTime",
                    LastUpdateUserColumnName = "LastUpdateUser",
                    LastUpdateDateTimeColumnName = "LastUpdateDateTime"
                };
            });

            entityFrameworkProject.Select("Sales.OrderHeader", settings => settings.EntitiesWithDataContracts = true);

            // Build features for project, group all entities by schema into a feature
            entityFrameworkProject.BuildFeatures();

            // Scaffolding =^^=
            entityFrameworkProject
                .ScaffoldEntityLayer()
                .ScaffoldDataLayer();

            var aspNetCoreProject = entityFrameworkProject
                .CreateAspNetCoreProject("OnlineStoreWithFluentValidation.WebAPI", @"./", entityFrameworkProject.Database);

            aspNetCoreProject.GlobalSelection(settings => {
                settings.ForceOverwrite = true;
            });

            aspNetCoreProject.Select("Sales.OrderDetail", settings => {
                settings.ConcurrencyToken = "123";
                settings.EntitiesWithDataContracts = true;
                settings.Validate();
            });

            aspNetCoreProject
                .ScaffoldAspNetCore();
        }
    }
}
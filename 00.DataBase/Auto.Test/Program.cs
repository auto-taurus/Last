using System;
using CatFactory.AspNetCore;
using CatFactory.CodeFactory;
using CatFactory.EfCore;
using CatFactory.SqlServer;

namespace Auto.Test {
    class Program {
        //private static string key = "server=.;database=auto_news;integrated security=yes;";
        private static string key = "server=.;database=master;integrated security=yes;";
        static void Main(string[] args) {
            A();
        }
        static void A() {
            // Import database
            var factory = new SqlServerDatabaseFactory() {
                ConnectionString = key
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
            aspNetCoreProject.GlobalSelection(settings => {
                settings.ForceOverwrite = true;
            });
            var se = new ProjectFeature<AspNetCoreProjectSettings>();
            aspNetCoreProject.AddFeature(se);
            aspNetCoreProject.ScaffoldAspNetCore();

        }
        static void B() {
            // Import database
            var factory = new SqlServerDatabaseFactory() {
                ConnectionString = key

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
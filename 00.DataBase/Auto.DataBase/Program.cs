using System;
using System.Threading.Tasks;
using CatFactory.AspNetCore;
using CatFactory.EntityFrameworkCore;
using CatFactory.ObjectRelationalMapping;
using CatFactory.ObjectRelationalMapping.Actions;
using CatFactory.SqlServer;

namespace Auto.DataBase {
    class Program {
        static async Task Main(string[] args) {
            Console.WriteLine("Hello World!");
            // CodeE();
            await CodeG();
        }
        public static void CodeA() {
            // Create database factory
            var databaseFactory = new SqlServerDatabaseFactory {
                DatabaseImportSettings = new DatabaseImportSettings {
                    ConnectionString = "server=.;database=auto_news;integrated security=yes;",
                }
            };

            // Import database
            var database = databaseFactory.Import();

            // Create instance of Entity Framework Core project

            var project = EntityFrameworkCoreProject
                .CreateForV2x("OnlineStore.Domain", database, @"../OnlineStore.Domain");
            var dd = project.GetEntityConfigurationName(new Table { Name = "System_Logs" });
            Console.WriteLine(dd);
            // Apply settings for Entity Framework Core project
            project.GlobalSelection(settings => {
                settings.ForceOverwrite = true;
                settings.ConcurrencyToken = "Timestamp";
                settings.AuditEntity = new AuditEntity {
                    CreationUserColumnName = "CreationUser",
                    CreationDateTimeColumnName = "CreationDateTime",
                    LastUpdateUserColumnName = "LastUpdateUser",
                    LastUpdateDateTimeColumnName = "LastUpdateDateTime"
                };
                // settings.DefaultSchemaAsSubdirectory = true;
                // settings.AddConfigurationForDefaultsInFluentAPI = true;
                // settings.AddConfigurationForChecksInFluentAPI = true;
                // settings.AddConfigurationForUniquesInFluentAPI = true;
                // settings.AddConfigurationForForeignKeysInFluentAPI = true;
                // settings.EntitiesWithDataContracts = true;
                // settings.DeclareNavigationProperties = true;
                // settings.DeclareNavigationPropertiesAsVirtual = true;
                // settings.PluralizeDbSetPropertyNames = true;
                // // settings.UseMefForEntitiesMapping = true;
                // settings.UseDataAnnotations = true;
                // settings.EnableDataBindings = true;
                // settings.UseAutomaticPropertiesForEntities = true;
                // settings.SimplifyDataTypes = true;
                // settings.ForceOverwrite = true;
                // settings.DefaultSchemaAsNamespace = true;
                // settings.Validate().ValidationMessages.Add(new CatFactory.Diagnostics.ValidationMessage() { Message = "123" });
                // settings.DeclareDbSetPropertiesInDbContext = false;
            });

            project.Selection("dbo.Web_News", settings => {
                settings.EntitiesWithDataContracts = true;
                settings.AddConfigurationForForeignKeysInFluentAPI = true;
                settings.DeclareNavigationProperties = true;
            });

            // Build features for project, group all entities by schema into a feature
            // Scaffolding =^^=
            project.ScaffoldEntityLayer().ScaffoldDataLayer().ScaffoldDomain();

        }
        public static void CodeB() {
            // Arrange

            // Create database factory
            var databaseFactory = new SqlServerDatabaseFactory {
                DatabaseImportSettings = new DatabaseImportSettings {
                    ConnectionString = "server=.;database=auto_news;integrated security=yes;",
                }
            };

            // Import database
            var database = databaseFactory.Import();
            // Create instance of Entity Framework Core project
            var project = EntityFrameworkCoreProject
                .CreateForV2x("OnlineStore", database, @"../OnlineStoreA");

            // Act

            // Apply settings for Entity Framework Core project
            project.GlobalSelection(settings => {
                settings.ForceOverwrite = true;
                settings.ConcurrencyToken = "Timestamp";
                settings.AuditEntity = new AuditEntity {
                    CreationUserColumnName = "CreationUser",
                    CreationDateTimeColumnName = "CreationDateTime",
                    LastUpdateUserColumnName = "LastUpdateUser",
                    LastUpdateDateTimeColumnName = "LastUpdateDateTime"
                };
            });

            project.Selection("dbo.system_users", settings => settings.EntitiesWithDataContracts = true);

            var orderHeader = database.FindTable("dbo.system_users");

            var selectionForOrder = project.GetSelection(orderHeader);
            project.ScaffoldEntityLayer().ScaffoldDataLayer().ScaffoldDomain();
        }
        public static void CodeC() {
            // Create database factory
            var databaseFactory = new SqlServerDatabaseFactory {
                DatabaseImportSettings = new DatabaseImportSettings {
                    ConnectionString = "server=.;database=auto_news;integrated security=yes;",
                        Exclusions = {
                            "dbo.sysdiagrams"
                            }
                            }
            };

            // Import database
            var database = databaseFactory.Import();

            // Create instance of Entity Framework Core project
            var project = EntityFrameworkCoreProject
                .CreateForV2x("OnlineStore.DomainA", database, @"../OnlineStore.DomainA");

            // Apply settings for Entity Framework Core project
            project.GlobalSelection(settings => {
                settings.ForceOverwrite = true;
                settings.ConcurrencyToken = "Timestamp";
                settings.AuditEntity = new AuditEntity {
                    CreationUserColumnName = "CreationUser",
                    CreationDateTimeColumnName = "CreationDateTime",
                    LastUpdateUserColumnName = "LastUpdateUser",
                    LastUpdateDateTimeColumnName = "LastUpdateDateTime"
                };

                settings.AddConfigurationForUniquesInFluentAPI = true;
                settings.AddConfigurationForForeignKeysInFluentAPI = true;
                settings.DeclareNavigationProperties = true;
            });

            project.Selection("Sales.OrderHeader", settings => {
                settings.EntitiesWithDataContracts = true;
                settings.AddConfigurationForForeignKeysInFluentAPI = true;
                settings.DeclareNavigationProperties = true;
            });

            // Build features for project, group all entities by schema into a feature
            project.BuildFeatures();

            // Scaffolding =^^=
            project
                .ScaffoldDomain();

        }
        public static void CodeD() {
            // Create database factory
            var databaseFactory = new SqlServerDatabaseFactory {
                DatabaseImportSettings = new DatabaseImportSettings {
                    ConnectionString = "server=.;database=auto_news;integrated security=yes;",
                }
            };

            // Import database
            var database = databaseFactory.Import();
            // Create instance of Entity Framework Core Project
            var entityFrameworkProject = new EntityFrameworkCoreProject {
                Name = "OnLineStore.Core",
                Database = database,
                OutputDirectory = "../OnLineStore.Core"
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

                settings.DeclareNavigationProperties = true;
                settings.AddConfigurationForUniquesInFluentAPI = true;
                settings.AddConfigurationForForeignKeysInFluentAPI = true;
                settings.DeclareNavigationProperties = true;
                settings.DeclareNavigationPropertiesAsVirtual = true;
                settings.EntitiesWithDataContracts = true;
                settings.DefaultSchemaAsSubdirectory = true;
                settings.AddConfigurationForDefaultsInFluentAPI = true;
                settings.AddConfigurationForChecksInFluentAPI = true;
                settings.AddConfigurationForUniquesInFluentAPI = true;
                settings.AddConfigurationForForeignKeysInFluentAPI = true;
                settings.EntitiesWithDataContracts = true;
                settings.DeclareNavigationProperties = true;
                settings.DeclareNavigationPropertiesAsVirtual = true;
                settings.PluralizeDbSetPropertyNames = true;
                // settings.UseMefForEntitiesMapping = true;
                settings.UseDataAnnotations = true;
                settings.EnableDataBindings = true;
                settings.UseAutomaticPropertiesForEntities = true;
                settings.SimplifyDataTypes = true;
                settings.ForceOverwrite = true;
                settings.DefaultSchemaAsNamespace = true;
            });

            entityFrameworkProject.Selection("Sales.OrderHeader", settings => settings.EntitiesWithDataContracts = true);

            // Build features for project, group all entities by schema into a feature
            entityFrameworkProject.BuildFeatures();

            // Scaffolding =^^=
            entityFrameworkProject
                .ScaffoldEntityLayer()
                .ScaffoldDataLayer().ScaffoldDomain();

            var aspNetCoreProject = entityFrameworkProject
                .CreateAspNetCore3xProject("OnLineStore.WebApi", "../OnLineStore.WebApi");

            // Add event handlers to before and after of scaffold

            aspNetCoreProject.ScaffoldingDefinition += (source, args) => {
                // Add code to perform operations with code builder instance before to create code file
            };

            aspNetCoreProject.ScaffoldedDefinition += (source, args) => {
                // Add code to perform operations after of create code file
            };

            aspNetCoreProject.ScaffoldAspNetCore();

        }
        public static void CodeE() {
            var databaseFactory = new SqlServerDatabaseFactory {
                DatabaseImportSettings = new DatabaseImportSettings {
                    ConnectionString = "server=.;database=auto_news;integrated security=yes;",
                }
            };

            // Import database
            var database = databaseFactory.Import();
            // Create instance of Entity Framework Core Project
            var entityFrameworkProject = new EntityFrameworkCoreProject {
                Name = "OnLineStore.Core",
                Database = database,
                OutputDirectory = "../OnLineStore.Core"
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

            entityFrameworkProject.Selection("Sales.OrderHeader", settings => settings.EntitiesWithDataContracts = true);

            // Build features for project, group all entities by schema into a feature
            entityFrameworkProject.BuildFeatures();

            // Scaffolding =^^=
            entityFrameworkProject
                .ScaffoldEntityLayer()
                .ScaffoldDataLayer();

            var aspNetCoreProject = entityFrameworkProject
                .CreateAspNetCore2xProject("OnlineStore.WebAPI", @"../OnlineStore.WebAPI");

            aspNetCoreProject.GlobalSelection(settings => settings.ForceOverwrite = true);

            aspNetCoreProject.Selection("Sales.OrderDetail", settings => {
                settings
                    .RemoveAction<ReadAllAction>()
                    .RemoveAction<ReadByKeyAction>()
                    .RemoveAction<AddEntityAction>()
                    .RemoveAction<UpdateEntityAction>()
                    .RemoveAction<RemoveEntityAction>();
            });

            aspNetCoreProject.ScaffoldAspNetCore();

        }
        public static async Task CodeF() {
            // Import database
            var database = await SqlServerDatabaseFactory
                .ImportAsync("server=.;database=auto_news;integrated security=yes;");

            // Create instance of Entity Framework Core Project
            var entityFrameworkProject = EntityFrameworkCoreProject
                .CreateForV2x("OnlineStore.Core", database, @"D:/A");

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

            entityFrameworkProject.Selection("Sales.OrderHeader", settings => settings.EntitiesWithDataContracts = true);

            // Build features for project, group all entities by schema into a feature
            entityFrameworkProject.BuildFeatures();

            // Scaffolding =^^=
            entityFrameworkProject
                .ScaffoldEntityLayer()
                .ScaffoldDataLayer();

            var aspNetCoreProject = entityFrameworkProject
                .CreateAspNetCore2xProject("OnlineStoreWithFluentValidation.WebAPI", @"D:/A");

            aspNetCoreProject.GlobalSelection(settings => {
                settings.ForceOverwrite = true;
                settings.UseDataAnnotationsToValidateRequestModels = false;
            });

            aspNetCoreProject.Selection("Sales.OrderDetail", settings => {
                settings
                    .RemoveAction<ReadAllAction>()
                    .RemoveAction<ReadByKeyAction>()
                    .RemoveAction<AddEntityAction>()
                    .RemoveAction<UpdateEntityAction>()
                    .RemoveAction<RemoveEntityAction>();
            });

            aspNetCoreProject
                .ScaffoldFluentValidation()
                .ScaffoldAspNetCore();

        }
        public static async Task CodeG() {
            // Import database
            var database = await SqlServerDatabaseFactory
                .ImportAsync("server=.;database=auto_news;integrated security=yes;", "dbo.sysdiagrams");

            // Create instance of Entity Framework Core Project
            var entityFrameworkProject = EntityFrameworkCoreProject
                .CreateForV2x("Northwind.Core", database, @"D:/B");

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

            entityFrameworkProject.Selection("dbo.Orders", settings => settings.EntitiesWithDataContracts = true);

            // Build features for project, group all entities by schema into a feature
            entityFrameworkProject.BuildFeatures();

            // Scaffolding =^^=
            entityFrameworkProject
                .ScaffoldEntityLayer()
                .ScaffoldDataLayer();

            var aspNetCoreProject = entityFrameworkProject
                .CreateAspNetCore2xProject("Northwind.WebAPI", @"D:/B");

            aspNetCoreProject.GlobalSelection(settings => settings.ForceOverwrite = true);

            aspNetCoreProject.ScaffoldFluentValidation().ScaffoldAspNetCore();

        }
    }
}
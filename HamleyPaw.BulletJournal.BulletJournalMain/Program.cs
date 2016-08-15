using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HamleyPaw.BulletJournal.BulletJournalMain;
using HamleyPaw.BulletJournal.BulletJournalMain.ViewModels;

using HamleyPaw.BulletJournal.Services;
using SimpleInjector;


    static class Program
    {
        [STAThread]
        public static void Main()
        {
            var container = Bootstrap();

            // Any additional other configuration, e.g. of your desired MVVM toolkit.

            RunApplication(container);
        }

        private static Container Bootstrap()
        {
            // Create the container as usual.
            var container = new Container();

            var connectionString =
                System.Configuration.ConfigurationManager
                    .ConnectionStrings["BulletJournalEntitiesContext"].ConnectionString;

            // Register your types, for instance:
            container.RegisterSingleton<IConnectionProvider>(new ConnectionProvider(connectionString));
            container.Register<IEntityService, EntityService>(Lifestyle.Transient);
            container.Register<IModelService, ModelService>(Lifestyle.Transient);

            // Register your windows and view models:
            container.Register<MainWindow>();
            container.Register<MainViewModel>();

            container.Verify();

            return container;
        }

        private static void RunApplication(Container container)
        {
            try
            {
                var app = new App();
                var mainWindow = container.GetInstance<MainWindow>();
                app.Run(mainWindow);
            }
            catch (Exception ex)
            {
                //Log the exception and exit
            }
        }
    }


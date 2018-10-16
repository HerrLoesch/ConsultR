namespace ConsultR
{
    using System.Windows;

    using ConsultR.Publications;

    using Prism.Modularity;
    using Prism.Regions;
    using Prism.Unity;

    using Unity;

    public class Bootstraper : UnityBootstrapper
    {
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
        }

        protected override DependencyObject CreateShell()
        {
            var shell = this.Container.Resolve<MainWindow>();
            return shell;
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }

        protected override void ConfigureModuleCatalog()
        {
            this.ModuleCatalog.AddModule(new ModuleInfo(typeof(PublicationsModule)));
        }

        protected override void InitializeShell()
        {
            var shell = (MainWindow)this.Shell;
            Application.Current.MainWindow = shell;

            shell.Show();
        }
    }
}

﻿namespace ConsultR
{
    using System.Windows;

    using ConsultR.Interfaces;
    using ConsultR.Logic;

    using Prism.Unity;

    using Unity;

    public class Bootstraper : UnityBootstrapper
    {
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            this.Container.RegisterType<IPublicationManager, PublicationManager>();
        }

        protected override DependencyObject CreateShell()
        {
            var shell = this.Container.Resolve<MainWindow>();
            return shell;
        }

        protected override void InitializeShell()
        {
            var shell = (MainWindow)this.Shell;
            Application.Current.MainWindow = shell;

            shell.Show();
        }
    }
}
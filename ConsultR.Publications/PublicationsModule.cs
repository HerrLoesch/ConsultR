﻿namespace ConsultR.Publications
{
    using ConsultR.Publications.Interfaces;
    using ConsultR.Publications.Logic;
    using ConsultR.Publications.Views;

    using Prism.Ioc;
    using Prism.Modularity;
    using Prism.Regions;

    public class PublicationsModule : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register(typeof(IPublicationManager), typeof(PublicationManager));
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("MainRegion", typeof(PublicationOverviewView));
        }
    }
}

namespace ConsultR.Publications.ViewModels
{
    using System.Collections.Generic;

    using ConsultR.Publications.Data;

    public interface IPublicationOverviewViewModel
    {
        void Initialize();

        IEnumerable<Publication> AvailablePublications { get; }

        Publication SelectedPublication { get; set; }
    }
}
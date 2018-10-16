namespace ConsultR.Publications.ViewModels
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using ConsultR.Publications.Data;
    using ConsultR.Publications.Interfaces;

    public class PublicationOverviewViewModel : INotifyPropertyChanged, IPublicationOverviewViewModel
    {
        private IPublicationManager publicationManager;

        private IEnumerable<Publication> availablePublications;

        private Publication selectedPublication;

        public PublicationOverviewViewModel(IPublicationManager publicationManager)
        {
            this.publicationManager = publicationManager;
            this.AvailablePublications = new List<Publication>();
        }

        public void Initialize()
        {
            this.AvailablePublications = this.publicationManager.GetAllPublications();
            this.SelectedPublication = this.AvailablePublications.FirstOrDefault();
        }

        public IEnumerable<Publication> AvailablePublications
        {
            get => this.availablePublications;
            private set
            {
                this.availablePublications = value;
                this.OnPropertyChanged();
            } 
        }

        public Publication SelectedPublication
        {
            get => this.selectedPublication;
            set
            {
                this.selectedPublication = value;
                this.OnPropertyChanged();
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

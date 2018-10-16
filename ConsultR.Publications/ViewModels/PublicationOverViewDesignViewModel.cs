using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultR.Publications.ViewModels
{
    using ConsultR.Publications.Data;

    public class PublicationOverviewDesignViewModel : IPublicationOverviewViewModel
    {

        public PublicationOverviewDesignViewModel()
        {
            this.SelectedPublication = new Publication();
            this.SelectedPublication.Name = "MVVM für Alle";

            this.AvailablePublications = new List<Publication>()
                                             {
                                                 this.SelectedPublication
                                             };
        }

        public void Initialize()
        {
        }

        public IEnumerable<Publication> AvailablePublications { get; set;  }

        public Publication SelectedPublication { get; set; }
    }
}

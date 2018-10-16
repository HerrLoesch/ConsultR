namespace ConsultR.Publications.Views
{
    using System.Windows.Controls;

    using ConsultR.Publications.ViewModels;

    /// <summary>
    /// Interaction logic for PublicationOverviewView.xaml
    /// </summary>
    public partial class PublicationOverviewView : UserControl
    {
        public PublicationOverviewView()
        {
            this.InitializeComponent();
        }

        public PublicationOverviewView(PublicationOverviewViewModel viewModel)
        {
            this.InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}

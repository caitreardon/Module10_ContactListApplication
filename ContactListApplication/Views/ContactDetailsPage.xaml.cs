using ContactListApplication.ViewModels;

namespace ContactListApplication.Views
{
    public partial class ContactDetailsPage : ContentPage
    {
        public ContactDetailsPage(ContactDetailsViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
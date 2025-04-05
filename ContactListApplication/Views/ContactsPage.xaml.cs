using ContactListApplication.ViewModels;

namespace ContactListApplication.Views
{
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage(ContactsViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
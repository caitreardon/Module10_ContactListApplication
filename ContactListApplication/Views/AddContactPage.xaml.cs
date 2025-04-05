using ContactListApplication.ViewModels;

namespace ContactListApplication.Views
{
    public partial class AddContactPage : ContentPage
    {
        public AddContactPage(AddContactViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
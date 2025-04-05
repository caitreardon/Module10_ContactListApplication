using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactListApplication.Models;
using System.Collections.ObjectModel;

namespace ContactListApplication.ViewModels
{
    public partial class ContactsViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ContactItem> contacts;

        [ObservableProperty]
        private ContactItem selectedContact;

        public ContactsViewModel()
        {
            Contacts = new ObservableCollection<ContactItem>();
        }

        [RelayCommand]
        private async Task ContactSelected()
        {
            if (SelectedContact == null)
                return;

            var navigationParameter = new Dictionary<string, object>
            {
                { "ContactItem", SelectedContact },
                { "Contacts", Contacts }
            };

            await Shell.Current.GoToAsync("ContactDetailsPage", navigationParameter);

            // Reset selection
            SelectedContact = null;
        }

        [RelayCommand]
        private async Task AddNewContact()
        {
            await Shell.Current.GoToAsync("//AddContactPage");
        }
    }
}
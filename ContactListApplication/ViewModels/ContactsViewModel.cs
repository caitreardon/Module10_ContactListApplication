using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactListApplication.Models;
using System.Collections.ObjectModel;

namespace ContactListApplication.ViewModels
{
    public partial class ContactsViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Contact> contacts;

        [ObservableProperty]
        private Contact selectedContact;

        public ContactsViewModel()
        {
            Contacts = new ObservableCollection<Contact>();
        }

        [RelayCommand]
        private async Task ContactSelected()
        {
            if (SelectedContact == null)
                return;

            var navigationParameter = new Dictionary<string, object>
            {
                { "Contact", SelectedContact },
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
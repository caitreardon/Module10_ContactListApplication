using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactListApplication.Models;
using System.Collections.ObjectModel;
using static Android.Util.EventLogTags;
using static Java.Util.Jar.Attributes;

namespace ContactListApplication.ViewModels
{
    public partial class AddContactViewModel : ObservableObject
    {
        [ObservableProperty]
        private string name;

        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string phoneNumber;

        [ObservableProperty]
        private string description;

        private ObservableCollection<Contact> _contacts;

        public AddContactViewModel(ObservableCollection<Contact> contacts)
        {
            _contacts = contacts;
        }

        [RelayCommand]
        private async Task SaveContact()
        {
            if (string.IsNullOrWhiteSpace(Name) ||
                string.IsNullOrWhiteSpace(Email) ||
                string.IsNullOrWhiteSpace(PhoneNumber))
            {
                await Shell.Current.DisplayAlert("Error", "Name, Email, and Phone Number are required fields.", "OK");
                return;
            }

            var newContact = new Contact
            {
                Name = Name,
                Email = Email,
                PhoneNumber = PhoneNumber,
                Description = Description
            };

            _contacts.Add(newContact);

            // Clear the form
            Name = string.Empty;
            Email = string.Empty;
            PhoneNumber = string.Empty;
            Description = string.Empty;

            // Navigate to the contacts page
            await Shell.Current.GoToAsync("//ContactsPage");
        }
    }
}
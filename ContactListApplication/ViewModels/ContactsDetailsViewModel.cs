using Android.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactListApplication.Models;
using System.Collections.ObjectModel;

namespace ContactListApplication.ViewModels
{
    [QueryProperty(nameof(Contact), "Contact")]
    [QueryProperty(nameof(Contacts), "Contacts")]
    public partial class ContactDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        private Contact contact;

        [ObservableProperty]
        private ObservableCollection<Contact> contacts;

        [ObservableProperty]
        private bool isEditing = false;

        [ObservableProperty]
        private string editName;

        [ObservableProperty]
        private string editEmail;

        [ObservableProperty]
        private string editPhoneNumber;

        [ObservableProperty]
        private string editDescription;

        [RelayCommand]
        private async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        private void EnableEditing()
        {
            EditName = Contact.Name;
            EditEmail = Contact.Email;
            EditPhoneNumber = Contact.PhoneNumber;
            EditDescription = Contact.Description;
            IsEditing = true;
        }

        [RelayCommand]
        private async Task SaveChanges()
        {
            if (string.IsNullOrWhiteSpace(EditName) ||
                string.IsNullOrWhiteSpace(EditEmail) ||
                string.IsNullOrWhiteSpace(EditPhoneNumber))
            {
                await Shell.Current.DisplayAlert("Error", "Name, Email, and Phone Number are required fields.", "OK");
                return;
            }

            Contact.Name = EditName;
            Contact.Email = EditEmail;
            Contact.PhoneNumber = EditPhoneNumber;
            Contact.Description = EditDescription;

            IsEditing = false;
            OnPropertyChanged(nameof(Contact));
        }

        [RelayCommand]
        private void CancelEditing()
        {
            IsEditing = false;
        }
    }
}
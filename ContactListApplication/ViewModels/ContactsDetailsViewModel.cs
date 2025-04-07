using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactListApplication.Models;
using System.Collections.ObjectModel;

namespace ContactListApplication.ViewModels
{
    [QueryProperty(nameof(ContactItem), "ContactItem")]
    [QueryProperty(nameof(Contacts), "Contacts")]
    public partial class ContactDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        private ContactItem contactItem;

        [ObservableProperty]
        private ObservableCollection<ContactItem> contacts;

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

        //[RelayCommand]
        //private async Task GoBack()
        //{
        //    await Shell.Current.GoToAsync("..");
        //}

        //[RelayCommand]
        //private void EnableEditing()
        //{
        //    EditName = ContactItem.Name;
        //    EditEmail = ContactItem.Email;
        //    EditPhoneNumber = ContactItem.PhoneNumber;
        //    EditDescription = ContactItem.Description;
        //    IsEditing = true;
        //}

        //[RelayCommand]
        //private async Task SaveChanges()
        //{
        //    if (string.IsNullOrWhiteSpace(EditName) ||
        //        string.IsNullOrWhiteSpace(EditEmail) ||
        //        string.IsNullOrWhiteSpace(EditPhoneNumber))
        //    {
        //        await Shell.Current.DisplayAlert("Error", "Name, Email, and Phone Number are required fields.", "OK");
        //        return;
        //    }

        //    ContactItem.Name = EditName;
        //    ContactItem.Email = EditEmail;
        //    ContactItem.PhoneNumber = EditPhoneNumber;
        //    ContactItem.Description = EditDescription;

        //    IsEditing = false;
        //    OnPropertyChanged(nameof(ContactItem));
        //}

        //[RelayCommand]
        //private void CancelEditing()
        //{
        //    IsEditing = false;
        //}
    }
}
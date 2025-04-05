using Microsoft.Extensions.Logging;
using ContactListApplication.Models;
using ContactListApplication.ViewModels;
using ContactListApplication.Views;
using System.Collections.ObjectModel;

namespace ContactListApplication
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Create a singleton of ObservableCollection<Contact> for sharing contacts between pages
            var contacts = new ObservableCollection<ContactItem>();
            builder.Services.AddSingleton(contacts);

            // Register ViewModels
            builder.Services.AddTransient<AddContactViewModel>();
            builder.Services.AddSingleton<ContactsViewModel>();
            builder.Services.AddTransient<ContactDetailsViewModel>();

            // Register Pages
            builder.Services.AddTransient<AddContactPage>();
            builder.Services.AddSingleton<ContactsPage>();
            builder.Services.AddTransient<ContactDetailsPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
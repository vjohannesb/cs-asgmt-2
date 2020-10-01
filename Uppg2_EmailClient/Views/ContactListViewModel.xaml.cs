using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Uppg2_EmailClient.Controls;
using Uppg2_EmailClient.Models;

namespace Uppg2_EmailClient.Views
{
    /// <summary>
    /// Interaction logic for ContactListViewModel.xaml
    /// </summary>
    public partial class ContactListViewModel : UserControl
    {
        public string ee { get; set; }
        public ContactListViewModel()
        {
            InitializeComponent();

            ImageSource contactImage = new BitmapImage(new Uri(@"..\Images\ContactImage.jpg", UriKind.Relative));

            // Mock-data
            Dictionary<string, string> contactList = new Dictionary<string, string>
            {
                { "Aa Aa", "Administrator" },
                { "Bb Bb", "Booleanist" },
                { "Cc Cc", "CEO" },
                { "Dd Dd", "Developer" },
                { "Ee Ee", "Engineer" }
            };

            // Lägg till element i stackpanel
            foreach (var kvp in contactList)
            {
                spContactList.Children.Add(new ContactControl()
                {
                    ContactName = kvp.Key,
                    ContactRole = kvp.Value,
                    ContactImage = contactImage,

                    // Skicka med referenser till andra vyn (kanske inte best practice men..)
                    ContactNameView = tbContactNameView,
                    ContactRoleView = tbContactRoleView 
                });
            }
        }
    }
}

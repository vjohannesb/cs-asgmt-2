using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Uppg2_EmailClient.Models;
using Uppg2_EmailClient.Controls;
using Uppg2_EmailClient.Views;

namespace Uppg2_EmailClient

{    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        ContactListModel contactListViewModel = new ContactListModel();
        InboxViewModel inboxViewModel = new InboxViewModel();
        GenericModel genericModel = new GenericModel();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMessages_Click(object sender, RoutedEventArgs e) 
            => DataContext = inboxViewModel;

        private void btnContacts_Click(object sender, RoutedEventArgs e)
            => DataContext = contactListViewModel;

        private void btnCalendar_Click(object sender, RoutedEventArgs e)
            => DataContext = genericModel;

        private void btnTasks_Click(object sender, RoutedEventArgs e)
            => DataContext = genericModel;

        private void btnSettings_Click(object sender, RoutedEventArgs e)
            => DataContext = genericModel;

    }
}

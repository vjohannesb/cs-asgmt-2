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
using Uppg2_EmailClient.Models;
using Uppg2_EmailClient.Views;

namespace Uppg2_EmailClient.Controls
{
    /// <summary>
    /// Interaction logic for ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
        }


        public ImageSource ContactImage
        {
            get { return imgContactImage.Source; }
            set { imgContactImage.Source = value; }
        }

        public string ContactName
        {
            get { return tbContactName.Text; }
            set { tbContactName.Text = value; }
        }

        public string ContactRole
        {
            get { return tbContactRole.Text; }
            set { tbContactRole.Text = value; }
        }

        public TextBlock ContactNameView { get; set; }
        public TextBlock ContactRoleView { get; set; }

        // Ändra nedifrån känns inte riktigt "best practice", men det var
        // det bästa jag kunde komma på utan att ge mig in i eventrutter...
        private void btnContactExpand_Click(object sender, RoutedEventArgs e)
        {
            ContactNameView.Text = ContactName;
            ContactRoleView.Text = ContactRole;
        }
    }
}

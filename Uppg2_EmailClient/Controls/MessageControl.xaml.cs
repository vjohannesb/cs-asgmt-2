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

namespace Uppg2_EmailClient.Controls
{
    /// <summary>
    /// Interaction logic for MessageControl.xaml
    /// </summary>
    public partial class MessageControl : UserControl
    {
        public MessageControl()
        {
            InitializeComponent();
        }

        public string SenderName
        {
            get { return tbSenderName.Text; }
            set { tbSenderName.Text = $"from {value}"; }
        }

        public string MessageSubject
        {
            get { return tbMessageSubject.Text; }
            set { tbMessageSubject.Text = value; }
        }

        public string MessageText { get; set; }

        public string MessageTextTrunc
        {
            get { return tbMessageShort.Text; }
            set { tbMessageShort.Text = value; }
        }

        public string DateReceived
        {
            get { return tbDateDate.Text; }
            set { tbDateDate.Text = value; }
        }
        public string DayReceived
        {
            get { return tbDateDay.Text; }
            set { tbDateDay.Text = value; }
        }
        public string TimeReceived
        {
            get { return tbDateTime.Text; }
            set { tbDateTime.Text = value; }
        }

        public TextBlock SenderNameView { get; set; }
        public TextBlock MessageSubjectView { get; set; }
        public TextBlock MessageTextView { get; set; }
        public TextBlock DateView { get; set; }

        // Ändra nedifrån känns inte riktigt "best practice", men det var
        // det bästa jag kunde komma på utan att ge mig in i eventrutter...
        private void btnMessageExpand_Click(object sender, RoutedEventArgs e)
        {
            SenderNameView.Text = $"{SenderName} (email@email.com)";
            MessageSubjectView.Text = MessageSubject;
            MessageTextView.Text = MessageText;

            DateView.Text = $"{DateTime.Parse(DateReceived):dd MMM yyyy} {TimeReceived}";
        }
    }
}

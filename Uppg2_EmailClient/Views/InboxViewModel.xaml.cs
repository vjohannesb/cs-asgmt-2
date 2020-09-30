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
    /// Interaction logic for InboxViewModel.xaml
    /// </summary>
    public partial class InboxViewModel : UserControl
    {
        public InboxViewModel()
        {
            InitializeComponent();

            // Mock-data (bl.a. för att se skillnad på knapptryckningarna)
            string[] senderArray = { "Aa Aa", "Bb Bb", "Cc Cc", "Dd Dd", "Ee Ee" };
            string[] subjectArray = { "The Letter A", "The Letter B", "The Letter C", "The Letter D", "The Letter E" };

            var _dtNow = DateTime.Parse("2020-01-01 00:00");
            DateTime[] dateTimeArray = 
            { 
                _dtNow.AddHours(10), 
                _dtNow.AddHours(100), 
                _dtNow.AddHours(1000).AddMinutes(5000), 
                _dtNow.AddDays(123), 
                _dtNow.AddDays(248) 
            };

            string message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Nunc auctor nulla sed ligula ullamcorper, non tempor nisl dictum. " +
                "Nam laoreet vestibulum enim, vitae fringilla dolor laoreet in. " +
                "Nam elementum tortor a nisi eleifend, et commodo arcu faucibus. " +
                "Integer nec ultricies quam. Vivamus et tincidunt diam. " +
                "Curabitur viverra erat odio, sed malesuada velit congue eu. " +
                "Suspendisse semper ipsum elit, porta varius neque aliquet quis. " +
                "Morbi eleifend finibus nunc, a cursus ante. Donec justo arcu, rutrum eu dui sit amet, ornare viverra purus. ";
            message += "\n\n" + message;

            // Lägg till MessageControl's i Stackpanelvyn
            for (var i = 0; i < 5; i++)
            {
                spMessageList.Children.Add(new MessageControl()
                {
                    SenderName = senderArray[i],
                    MessageSubject = subjectArray[i],
                    MessageText = message,
                    MessageTextTrunc = message.Substring(0, 100),

                    DateReceived = dateTimeArray[i].ToShortDateString(),
                    DayReceived = dateTimeArray[i].DayOfWeek.ToString(),
                    TimeReceived = dateTimeArray[i].ToShortTimeString(),

                    // Skicka med referenser till andra vyn (kanske inte best practice men..)
                    SenderNameView = tbSenderView,
                    MessageSubjectView = tbSubjectView,
                    MessageTextView = tbMessageBodyView,
                    DateView = tbDateTimeReceivedView
                });
            }
        }
    }
}

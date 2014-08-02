using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Math_Alarm.Resources;
using Microsoft.Phone.Scheduler;

namespace Math_Alarm
{
    public partial class MainPage : PhoneApplicationPage
    {
        IEnumerable<ScheduledNotification> notifications;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            //Reset the ReminderListBox items when the page is navigated to.
            ResetItemsList();
        }

        //Method that resets the visibility of the items list.
        private void ResetItemsList()
        {
            notifications = ScheduledActionService.GetActions<ScheduledNotification>();

            if(notifications.Count<ScheduledNotification>() > 0)
            {
                EmptyTextBlock.Visibility = Visibility.Collapsed;
            }
            else
            {
                EmptyTextBlock.Visibility = Visibility.Visible;
            }

            NotificationListBox.ItemsSource = notifications;
        }

        //Delete button that is available whenever a new item is added.  Will be removed
        //to add a hold action on the items that brings up a delete button.
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            // The scheduled action name is stored in the Tag property
            // of the delete button for each reminder.
            string name = (string)((Button)sender).Tag;

            // Call Remove to unregister the scheduled action with the service.
            ScheduledActionService.Remove(name);

            // Reset the ReminderListBox items
            ResetItemsList();
        }

        //Navigates to the settings page (SettingsPage.xaml).
        private void settings_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/SettingsPage.xaml", UriKind.Relative));
        }

        //Navigates to the about page (AboutPage.xaml).
        private void about_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AboutPage.xaml", UriKind.Relative));
        }

        //Navigates to the alarm creation page (AlarmCreate.xaml).
        private void newAlarm_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/AlarmCreate.xaml", UriKind.Relative));
        }
    }
}
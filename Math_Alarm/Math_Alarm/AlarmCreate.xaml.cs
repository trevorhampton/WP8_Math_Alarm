using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Scheduler;

namespace Math_Alarm
{
    public partial class AlarmCreate : PhoneApplicationPage
    {
        String difficutlyLvl; 
        public AlarmCreate()
        {
            InitializeComponent();

            difficultyPicker.SelectedItem = easyDifficultySelection;
        }

        //Code that is executed once the application bar save button is clicked.
        private void ApplicationBarSaveButton_Click(object sender, EventArgs e)
        {
            String name = System.Guid.NewGuid().ToString();

            DateTime time = (DateTime)alarmTime.Value;

            Alarm alarm = new Alarm(name);
            alarm.BeginTime = time;

            //Adds the alarm created by the user to the list box on the main page
            //and sets it to be an actual scheduled service by the OS.
            ScheduledActionService.Add(alarm);
        }

        private void difficultyPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListPickerItem dpi = difficultyPicker.SelectedItem as ListPickerItem;
            difficutlyLvl = dpi.ToString();
        }
        
        //This method will return the level of difficulty that the user selects.
        private String getDifficulty()
        {
            return difficutlyLvl;
        }

        public String getAlarmName()
        {
            return nameTextBox.Text.ToString();
        }
    }
}
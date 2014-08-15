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
using Microsoft.Phone.Notification;

namespace Math_Alarm
{
    public partial class AlarmCreate : PhoneApplicationPage
    {
        String difficultyLvl;
        //Alarms[] alarms;

        public AlarmCreate()
        {
            InitializeComponent();

            difficultyPicker.SelectedItem = easyDifficultySelection;
        }

        //Code that is executed once the application bar save button is clicked.
        private void ApplicationBarSaveButton_Click(object sender, EventArgs e)
        {
            String name = nameTextBox.Text;
            DateTime time = (DateTime)alarmTime.Value;

            Alarm alarm = new Alarm(name);
            alarm.Content = nameTextBox.Text + "    Difficulty: " + getDifficulty();
            alarm.BeginTime = time;

            //Adds the alarm created by the user to the list box on the main page
            //and sets it to be an actual scheduled service by the OS.
            
            ScheduledActionService.Add(alarm);
        }

        //Sets difficultyLvl String to the current selected item in the difficultyPicker ListPicker.
        private void difficultyPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            difficultyLvl = difficultyPicker.SelectedItem.ToString();
            if (difficultyLvl.Equals("Very Hard"))
            {
                difficultyDescript.Text = "Calculus";
            }
        }
        
        //This method will return the level of difficulty that the user selects.
        public String getDifficulty()
        {
            difficultyLvl = difficultyPicker.SelectedItem.ToString();
            return difficultyLvl;
        }

        //Returns the name of the alarm being created.
        public String getAlarmName()
        {
            return nameTextBox.Text.ToString();
        }
    }
}
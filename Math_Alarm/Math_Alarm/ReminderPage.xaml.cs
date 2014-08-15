/*This page will be the one to display the problem once an alarm has gone off.*/

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
    public partial class ReminderPage : PhoneApplicationPage
    {
        int userAnswer;
        String userHardAnswer;
        MathOperations mathoperations = new MathOperations();
        AlarmCreate alarmCreate = new AlarmCreate();
        public ReminderPage()
        {
            InitializeComponent();
        }
        
        //Will determine if the problem has been solved by the user.  
        public bool isProblemSolved()
        {
            return true; // This output will be changed later.
        }

        public void resetAlarm()
        {
            ScheduledActionService.Find(alarmCreate.getAlarmName()).BeginTime.AddSeconds(10);
        }


    }
}
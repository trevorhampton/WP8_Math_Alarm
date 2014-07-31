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
using xFunc.Maths;

namespace Math_Alarm
{
    public partial class AlarmCreate : PhoneApplicationPage
    {
        String difficutlyLvl; 
        public AlarmCreate()
        {
            InitializeComponent();
            difficultyBox.Items.Add("Easy");
            difficultyBox.Items.Add("Normal");
            difficultyBox.Items.Add("Hard");
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

        //Method that decides and calculates the math problem that turns
        //off the alarm.  This method might be moved to another class e.g. MainPage.xaml.
        private void basicMathProblem()
        {
            Random random = new Random();
            int operationNum = random.Next(0, 1), answerNum;
            String operation;

            switch (operationNum)
            {
                case 0:
                    operation = "-";
                    break;
                case 1:
                    operation = "*";
                    break;
                default:
                    operation = "+";
                    break;
            }
            
            if (difficutlyLvl.Equals("Easy"))
            {
                if (operation.Equals("+"))
                {
                    answerNum = random.Next(0, 100) + random.Next(0, 100);
                }

                else if (operation.Equals("-"))
                {
                    answerNum = random.Next(0, 100) - random.Next(0, 100);
                }

                else
                {
                    answerNum = random.Next(0, 100) * random.Next(0, 100);
                }
            }

            else if (difficutlyLvl.Equals("Normal"))
            {
               
            }

            else
            {
                
            }
        }
        
        //This method will return the level of difficulty that user selects.
        //private String getDifficulty()
        //{
        //    //This line will be assign by the value of the difficultyBox object
        //    //to the difficultyLvl string once the user makes a selection from it. 

        //    return;
        //}
    }
}
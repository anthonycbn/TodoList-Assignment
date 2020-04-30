using System;
using System.Collections.Generic;
using System.Text;

namespace TODOLIST
{


    public class TodoList
    {
        public string NameOfActivity { get; set; }
        public string DayOfTheWeek { get; set; }
        public bool ActivityDone { get; set; }


        public static List<TodoList> listOfActivities = new List<TodoList>();


        public TodoList (string nameOfActivity, string dayOfTheWeek, bool activityDone)
        {
            NameOfActivity = nameOfActivity;
            DayOfTheWeek = dayOfTheWeek;
            ActivityDone = activityDone;
           
        }

        public static string TodoHistory()
        {
            var report = new System.Text.StringBuilder();

            

            report.AppendLine("\tSN\tActivity Name\t\tDay of the Week\t\tCompleted Activity");
            int serialNumber = 1;
            string activityConverter;
           
            foreach (var item in listOfActivities)
            {   

                if (item.ActivityDone == false)
                {
                    activityConverter = "Not Completed";
            
                }
                else
                {
                    activityConverter = "Completed";
                }
                report.AppendLine($"\t{serialNumber}\t{item.NameOfActivity}\t\t{item.DayOfTheWeek}\t\t\t{activityConverter}");
                serialNumber++;

                
            }
    
            return report.ToString();

        }

    }

}

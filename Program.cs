using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TODOLIST
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList item1 = new TodoList("learning", "Sunday", false);
            TodoList.listOfActivities.Add(item1);
            TodoList item2 = new TodoList("snurfing", "Monday", false);
            TodoList.listOfActivities.Add(item2);
            TodoList item3 = new TodoList("football", "Tuesday", false);
            TodoList.listOfActivities.Add(item3);
            TodoList item4 = new TodoList("praying", "Wednesday", false);
            TodoList.listOfActivities.Add(item4);
        begin:
            Console.WriteLine("Hello, welcome to your oragnizer: \n \t Press n for new entry\n \t Press h to view all todolist: \n \t Press e to modify entry: \n \t press 0 to exit application: ");
            string action = Console.ReadLine();
            
            if (action == "n")
            {
                Console.Write("Enter Name of Activity: ");
                string activity = Console.ReadLine();

                Console.Write("Enter the day of the week to perform this activity: ");
                string activityDay = Console.ReadLine();

                bool completed = false;

                
                TodoList newTodoList = new TodoList(activity, activityDay, completed);
                TodoList.listOfActivities.Add(newTodoList);


                Console.WriteLine($"You have added {newTodoList.NameOfActivity} as a todo activity to your todo list, you will perform this activity on {newTodoList.DayOfTheWeek}");

                Console.WriteLine(TodoList.TodoHistory());
            }

            if (action == "h")
            {
                
                Console.WriteLine(TodoList.TodoHistory());
            }

            if (action == "e")
                
            {
                editStart:
                Console.WriteLine("please select what you want to modify: \n \t press n for Name of Activity: \n \t press t for the date \n \t press s for status\n \t press 0 to exit application\n \t press m to the Main Menu");
                  string editAction = Console.ReadLine();

                  switch (editAction) 
                  {
                       case "n":
                        
                        Console.Write("Enter the Old name of activity: ");
                        string inputSearch = Console.ReadLine();
                    
                        for (int i = 0; i < TodoList.listOfActivities.Count; i++)
                        {
                            if (TodoList.listOfActivities[i].NameOfActivity == inputSearch)
                            {
                                Console.WriteLine("The activity name " + TodoList.listOfActivities[i].NameOfActivity + " was found in the Todo List");

                                Console.Write("Enter the new Name for the Activity: ");
                                TodoList.listOfActivities[i].NameOfActivity = Console.ReadLine();

                                Console.WriteLine(TodoList.TodoHistory());
                                goto editStart;
                            }
                            else if (TodoList.listOfActivities[i].NameOfActivity != inputSearch && i == (TodoList.listOfActivities.Count -1))
                            {
                                Console.WriteLine("Name not found in libray");
                                goto editStart;
                            }
                        } 
                        

                        break;

                        case "t":
                        Console.Write("Enter the Old name of activity: ");
                        string inputSearch1 = Console.ReadLine();
                      
                        for (int i = 0; i < TodoList.listOfActivities.Count; i++)
                        {
                            if (TodoList.listOfActivities[i].NameOfActivity == inputSearch1)
                            {
                                Console.WriteLine("The activity name " + TodoList.listOfActivities[i].NameOfActivity + " was found in the Todo List you are supposed to perform this activity on "+TodoList.listOfActivities[i].DayOfTheWeek);
                               

                                Console.Write("Enter the new Day of the Week for the Activity: ");
                                TodoList.listOfActivities[i].DayOfTheWeek = Console.ReadLine();

                                Console.WriteLine(TodoList.TodoHistory());
                                goto editStart;
                            }
                            else if (TodoList.listOfActivities[i].NameOfActivity != inputSearch1 && i == (TodoList.listOfActivities.Count-1))
                            {
                                Console.WriteLine("Name not found in libray");
                                goto editStart;
                            }
                        }
                        break;

                    case "s":
                        Console.Write("Enter the Old name of activity: ");
                        string inputSearch2 = Console.ReadLine();

                        for (int i = 0; i < TodoList.listOfActivities.Count; i++)
                        {
                            if (TodoList.listOfActivities[i].NameOfActivity == inputSearch2)
                            {
                                Console.WriteLine("The activity name " + TodoList.listOfActivities[i].NameOfActivity + " was found in the Todo List, the status of the activity is " + TodoList.listOfActivities[i].ActivityDone);

                                Console.Write("Enter true for Completed Status and false to revert status to incomplete activity: ");
                                TodoList.listOfActivities[i].ActivityDone = Convert.ToBoolean(Console.ReadLine());
                               
                                Console.WriteLine(TodoList.TodoHistory());
                                goto editStart;
                            }
                            else if (TodoList.listOfActivities[i].NameOfActivity != inputSearch2 && i == (TodoList.listOfActivities.Count - 1))
                            {
                                Console.WriteLine("Name not found in libray");
                                goto editStart;
                            }
                        } 
                        break;

                    case "0":
                        {
                            System.Environment.Exit(0);
                        }
                        break;
                    case "m":
                        {
                            goto begin;
                        }
                     
                    default:
                            Console.WriteLine("Select a valid alphabet to iniiate your update");
                        break;    
                  }
                
                
            }
            if (action == "0")
            {
                System.Environment.Exit(0);
            }
            goto begin;
        }  
    }
}

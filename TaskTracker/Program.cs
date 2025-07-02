namespace TaskTracker
{
    internal class Program
    {
        static string[] tasks = new string[100];
        static int taskIndex = 0;

        static void Main(string[] args)
        {
            //welcoming user
            //add task
            //view all tasks
            //mark task complete 
            //remove task 
            //exit

            Console.WriteLine("Welcom to my Task Tracker!");
            Console.WriteLine("------------------------------");


            while(true)
            {
                Console.WriteLine("Enter your choise from 1 to 5");

                Console.WriteLine("1: Add");
                Console.WriteLine("1: View");
                Console.WriteLine("1: Completed");
                Console.WriteLine("1: Remove");
                Console.WriteLine("1: Exit");
                Console.WriteLine("1: Add");

                string userChoise = Console.ReadLine();
                switch (userChoise)
                {
                    case "1":
                        //add task
                        AddTask();
                        break;
                    case "2":
                        //view task
                        ViewTasks();
                        break;
                    case "3":
                        //mark task
                        MarkComplete();
                        break;
                    case "4":
                        //remove task
                        RemoveTask();
                        break;
                    case "5":
                        //exit
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("please enter number from 1 to 5");
                        break;

                }
            }


        }

        private static void AddTask()
        {
            Console.WriteLine("Enter task title");
            string taskTitle =  Console.ReadLine();
            tasks[taskIndex] = taskTitle;
            Console.WriteLine("Task added sucessfully");

            taskIndex++;
        }

        private static void ViewTasks()
        {
            Console.WriteLine("Task list:");
            for(int i = 0; i< taskIndex; i++)
            {
                Console.WriteLine($"{i+1}. Task title : {tasks[i]}");
            }
        }
        private static void MarkComplete()
        {
            Console.WriteLine("Enter task number:");
            string taskNumber = Console.ReadLine();
            int taskID = Convert.ToInt32(taskNumber);
            tasks[taskID] = tasks[taskID] + "----COMPLETED";
        }

        private static void RemoveTask()
        {
            Console.WriteLine("Enter task number");
            string taskNumber = Console.ReadLine() ;
            int taskID = Convert.ToInt32(taskNumber);
            tasks[taskID] = string.Empty;
        }
    }
}

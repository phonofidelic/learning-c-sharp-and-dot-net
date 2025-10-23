using System;
using System.Collections.Generic;

namespace EnumsAndSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todos = new() {
                new Todo { Description = "Task 1", EstimatedHours = 2, Status = Status.Completed },
                new Todo { Description = "Task 2", EstimatedHours = 4, Status = Status.InProgress },
                new Todo { Description = "Task 3", EstimatedHours = 6, Status = Status.NotStarted },
                new Todo { Description = "Task 4", EstimatedHours = 1, Status = Status.Completed },
                new Todo { Description = "Task 5", EstimatedHours = 8, Status = Status.Completed },
                new Todo { Description = "Task 6", EstimatedHours = 3, Status = Status.InProgress },
                new Todo { Description = "Task 7", EstimatedHours = 2, Status = Status.OnHold },
                new Todo { Description = "Task 8", EstimatedHours = 2, Status = Status.NotStarted },
                new Todo { Description = "Task 9", EstimatedHours = 1, Status = Status.NotStarted },
                new Todo { Description = "Task 10", EstimatedHours = 12, Status = Status.NotStarted },
                new Todo { Description = "Task 11", EstimatedHours = 7, Status = Status.NotStarted },
                new Todo { Description = "Task 12", EstimatedHours = 5, Status = Status.Deleted },
                new Todo { Description = "Task 13", EstimatedHours = 1, Status = Status.NotStarted },
                new Todo { Description = "Task 14", EstimatedHours = 2, Status = Status.NotStarted },
            };

            PrintAssessment(todos);

            Console.ReadLine();
        }

        private static void PrintAssessment(List<Todo> todos)
        {
            foreach (Todo todo in todos)
            {
                string statusMessage = "";
                ConsoleColor backgroundColor = ConsoleColor.Black;
                switch (todo.Status)
                {
                    case Status.NotStarted:
                        backgroundColor = ConsoleColor.Red;
                        statusMessage = "NOT STARTED";
                        break;

                    case Status.InProgress:
                        backgroundColor = ConsoleColor.Green;
                        statusMessage = "IN PROGRESS";
                        break;

                    case Status.OnHold:
                        backgroundColor = ConsoleColor.DarkYellow;
                        statusMessage = "ON HOLD";
                        break;

                    case Status.Completed:
                        backgroundColor = ConsoleColor.Blue;
                        statusMessage = "COMPLETED";
                        break;

                    case Status.Deleted:
                        backgroundColor = ConsoleColor.Gray;
                        statusMessage = "DELETED";
                        break;

                    default:
                        break;
                }
                Console.Write(todo.Description + ": ");
                Console.BackgroundColor = backgroundColor;
                Console.Write(statusMessage);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("");
            }
        }

        class Todo
        {
            public string Description { get; set; } = "";
            public int EstimatedHours { get; set; }
            public Status Status { get; set; } = Status.NotStarted;
        }

        enum Status
        {
            NotStarted,
            InProgress,
            OnHold,
            Completed,
Deleted
        }
    }
}
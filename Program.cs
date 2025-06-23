using System;
using System.Collections.Generic;

namespace CS435_CSharpTodoList
{
    class TaskItem
    {
        public required string Description { get; set; }
        public bool IsComplete   { get; set; }

        public override string ToString()
        {
            return $"{(IsComplete ? "[✓]" : "[ ]")} {Description}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new List<TaskItem>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== To-Do List ===");
                if (tasks.Count == 0)
                    Console.WriteLine("  (no tasks yet)");
                else
                    for (int i = 0; i < tasks.Count; i++)
                        Console.WriteLine($" {i + 1}. {tasks[i]}");

                Console.WriteLine("\nMenu:");
                Console.WriteLine("  1) Add task");
                Console.WriteLine("  2) Mark complete");
                Console.WriteLine("  3) Remove task");
                Console.WriteLine("  4) Exit");
                Console.Write("Choose an option: ");

                var choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.Write("Enter task description: ");
                    var desc = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(desc))
                        tasks.Add(new TaskItem { Description = desc.Trim() });
                }
                else if (choice == "2" && tasks.Count > 0)
                {
                    Console.Write("Task number to mark complete: ");
                    if (int.TryParse(Console.ReadLine(), out int num) && num >= 1 && num <= tasks.Count)
                        tasks[num - 1].IsComplete = true;
                }
                else if (choice == "3" && tasks.Count > 0)
                {
                    Console.Write("Task number to remove: ");
                    if (int.TryParse(Console.ReadLine(), out int num) && num >= 1 && num <= tasks.Count)
                        tasks.RemoveAt(num - 1);
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
        }
    }
}

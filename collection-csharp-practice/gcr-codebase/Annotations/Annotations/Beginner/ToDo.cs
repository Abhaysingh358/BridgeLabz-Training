using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Annotations.Beginner
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class TodoAttribute : Attribute
    {
        public string Task { get; }
        public string AssignedTo { get; }
        public string Priority { get; }

        public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
        {
            Task = task;
            AssignedTo = assignedTo;
            Priority = priority;
        }
    }
    public class FeatureManager
    {
        [Todo("Implement login", "Alice", "HIGH")]
        [Todo("Add validation", "Bob")]
        public void Login()
        {
            Console.WriteLine("Login feature");
        }

        [Todo("Optimize database query", "Charlie", "LOW")]
        public void LoadData()
        {
            Console.WriteLine("Loading data");
        }
    }

    internal class ToDo
    {
        static void Main()
        {
            var methods = typeof(FeatureManager).GetMethods();

            foreach (var method in methods)
            {
                var todos = method.GetCustomAttributes<TodoAttribute>();

                foreach (var todo in todos)
                {
                    Console.WriteLine($"Method: {method.Name}, " + $"Task: {todo.Task}, " + $"AssignedTo: {todo.AssignedTo}, " + $"Priority: {todo.Priority}");
                }
            }
        }
    }
}

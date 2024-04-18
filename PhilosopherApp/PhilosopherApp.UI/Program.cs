using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PhilosopherApp.Data;
using PhilosopherApp.Domain;

namespace PhilosopherApp.UI
{
    class Program
    {
        private static PhilosopherContext _Context = new PhilosopherContext();

        //private static void Main(string[] args)
        //{
        //    _context.Database.EnsureCreated();
        //    GetSamurais("Before Add:");
        //    AddSamurai();
        //    GetSamurais("After Add:");
        //    Console.Write("Press any key...");
        //    Console.ReadKey();
        //}

        private static void Main(string[] args)
        {
            _Context.Database.EnsureCreated();
            GetPhilosophers("Before add:");
            AddPhilosopher();
            GetPhilosophers("After Add:");
            Console.Write("Press any key...");
            Console.ReadKey();
        }

        private static void AddPhilosopher() 
        {
            var philosopher = new Philosopher { Name = "Epicteto"};
            _Context.Philosophers.Add(philosopher); 
            _Context.SaveChanges();
        }

        private static void GetPhilosophers(string text)
        {
            var philosophers = _Context.Philosophers.ToList();

            Console.WriteLine($"{text}: Samurai count is {philosophers.Count}");

            foreach(var Philosopher in philosophers)
            {
                Console.WriteLine(Philosopher.Name);
            }
        }
    }

}


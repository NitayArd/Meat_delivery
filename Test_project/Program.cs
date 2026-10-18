using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using DtoLibary.Models;

namespace Test_project
{
    internal class Program
    {
        
        private static async Task PrepareCofeeAsync()
        {
            Console.WriteLine("Add water");
            Console.WriteLine("Start boiling some water ");
            await Task.Delay(2500);
            Console.WriteLine("Water is boiling.");
            Console.WriteLine("Add some coffee");
            Console.WriteLine("Add some sugar");
            Console.WriteLine("Add some water");
            Console.WriteLine("Add some water");
            Console.WriteLine("Stir your coffee");
            Console.WriteLine("Coffee drink is ready");
        }

        private static async Task PrepareToastAsync(int count)
        {
            for (int i = 1; i <= count; i++)
                Console.WriteLine("Put bread into the toaster");
                Console.WriteLine("Turn on the toaster");
            Console.WriteLine("Start toasting");
            await Task.Delay(8000);
            Console.WriteLine("Toasts popped out ");
            Console.WriteLine("Spread with a butter");
            Console.WriteLine(" Spread with a jam");
            Console.WriteLine("Toast is ready");
        }

        private static async Task PrepareAggsAsnyc(int count)
        {
            Console.WriteLine("Heating a pan");
            await Task.Delay(1000);
            Console.WriteLine("Pour oil into the pan.");
        for (int i = 1; i <= count; i++)
                Console.WriteLine("Break the egg into pan");
            Console.WriteLine("Frying eggs") ;
            await Task.Delay(7000);
            Console.WriteLine("Put eggs on a plate");
            Console.WriteLine("Fried eggs are ready");
        }

        static async Task GetBreakFastAsync()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Start making cofee");
            Task coffe = PrepareCofeeAsync();
            Console.WriteLine("Start making toasts");
            Task  toas = PrepareToastAsync(2);
            Console.WriteLine("Start making eggs");
            Task aggs = PrepareAggsAsnyc(2);
            await Task.WhenAll(coffe, toas, aggs);
            Console.WriteLine("Breakfast is ready");
            stopwatch.Stop();
            Console.WriteLine($"Breakfast preparation took {stopwatch.ElapsedMilliseconds} ms");
        }

        static void Main(string[] args)
        {
            TestModel();

            Console.ReadLine();
        }
            static async Task MainAsync(string[] args)
        {
            //GetBreakFastAsync();
          

        }

        static void TestModel()
        {
            User user = new User
            {
                UserId = "123456788",
                UserName = "nitay",
                UserEmail = "nnitay@gmail.com",
                UserPassword = "12345",
                UserPhone = "054-1234567",
                CityId = 1

            };

            ValidationContext context = new ValidationContext(user, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(user, context, results, true);
            if (isValid == true)
            {
                Console.WriteLine("THE USER IS CORRECT");
            }
            else
            {
                Console.WriteLine("THE USER IS NOT CORRECT");
                foreach (var validationResult in results)
                {
                    Console.WriteLine($"- {validationResult.ErrorMessage}");
                }
            }
        }
    }
    
}

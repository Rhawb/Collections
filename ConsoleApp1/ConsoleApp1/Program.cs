using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			Action<string> sayGreeting;

			Func<string, string> conversate = (message) => 
			{
				Console.WriteLine(message);
				return Console.ReadLine();
			};

			string input = conversate("What's your name?");

			sayGreeting = (greeting) =>
			{
				Console.WriteLine(string.Format(greeting, input));
			};

			sayGreeting("Hello {0}");
			conversate("Good to see you.");
			conversate("Y u do dis?");
			sayGreeting("Later {0}");

			Console.Read();
        }
    }
}
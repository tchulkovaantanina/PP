using System;

namespace Git 
{
	class Git 
	{
		static void Main(string[] arge)
		{
			System.Console.WriteLine("Enter your first name: ");
			string first_name = Console.ReadLine();
			Sestem.Console.WriteLine("Now enter your last name: ");
			string last_name = Console.ReadLine();
			System.Console.WriteLine($"Hello, {first_name} {last_name}!");
		}
	}
}
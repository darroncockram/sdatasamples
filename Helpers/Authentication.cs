using System;

namespace Helpers
{
    public static class Authentication
    {
		public static string GetUserName()
		{
			Console.WriteLine("Enter the user name to connect to the data (default is MANAGER):");
			string userName = Console.ReadLine();
			if (String.IsNullOrEmpty(userName))
			{
				userName = "MANAGER";
			}

			return userName;
		}

		public static string GetPassword()		
		{
			Console.WriteLine($"Enter the password for the above user");
			var password = String.Empty;
			ConsoleKeyInfo ch = Console.ReadKey(true);
			while (ch.Key != ConsoleKey.Enter)
			{
				password += ch.KeyChar;
				Console.Write('*');
				ch = Console.ReadKey(true);
			}
			Console.WriteLine();

			return password;
		}
	}
}

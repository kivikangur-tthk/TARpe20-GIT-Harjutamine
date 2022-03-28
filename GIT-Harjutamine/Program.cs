using System;

namespace GIT_Harjutamine
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hey, I'm Jarmo!");
			Console.WriteLine("Egert Arr asendus tekst");
			Console.WriteLine("midagi hello worldi asemele");
			Console.WriteLine("Hendris oli siin");
			Console.WriteLine("Hegert Taresalu Oli siin");
			Console.WriteLine("Lumi tuli maha ja valgeks läks maa!");
			Console.WriteLine("Kristjan oli siin.");
			Console.WriteLine("Sten Oli Siin");
		}

		public static void Hello(string[] args)
        {
			Console.WriteLine("Hello");
			string Greeting = Console.ReadLine().ToLower();
            while (true)
            {
				if (Greeting == "hello")
				{
					Console.WriteLine("Have a nice day");
					break;
				}
				else
				{
					Console.WriteLine("can you repeat that?");
				}
			}
        }
	}
}

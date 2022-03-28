using System;

namespace GIT_Harjutamine
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hey, I'm Jarmo!");
			Console.WriteLine("Egert Arr asendus tekst");
			Console.WriteLine("Hendris oli siin");
			Console.WriteLine("Hegert Taresalu Oli siin");
			Console.WriteLine("Lumi tuli maha ja valgeks läks maa!");
			Console.WriteLine("Kristjan oli siin.");

			WriteToConsole("Hello world!");
		}


		public static void WriteToConsole(string input)
        {
			Console.WriteLine(input);
        }
	}
}

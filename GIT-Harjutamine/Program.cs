using System;

namespace GIT_Harjutamine
{
	class Program
	{
		public static double calculatePersonalDose(double weight)
        {
			return weight * 1.5;
        }

		static void Main(string[] args)
		{	
			Console.WriteLine("genrix16 siin");
			Console.WriteLine("elu on lõbus karneval");
			Console.WriteLine("Hey, I'm Jarmo!");
			Console.WriteLine("Egert Arr asendus tekst");
			Console.WriteLine("midagi hello worldi asemele");
			Console.WriteLine("Hendris oli siin");
			Console.WriteLine("Hegert Taresalu Oli siin");
			Console.WriteLine("Lumi tuli maha ja valgeks läks maa!");
			Console.WriteLine("Kristjan oli siin.");
			// Kutsu välja omaloodud alamprogrammi
			Console.WriteLine("Sten Oli Siin");
 
			Console.WriteLine(calculatePersonalDose(50));


			WriteToConsole("hello world!");
			AlamProgramm();
			EgertFunk();
		}

        private static string TekstProgramm()
        {
            return "Tere :D 🎈🎈👓";
        }

        private static void AlamProgramm()
        {
            Console.WriteLine("Alamprogramm");
        

        Console.WriteLine("Tervitus Kasparilt.");
			Kasparfunk();
        }

		private static void EgertFunk()
		{
			Console.WriteLine("Egert tekst");
		}

		public static void Kasparfunk()
		{
			Console.WriteLine("function works");
		}
		public static void WriteToConsole(string input)
		{
			Console.WriteLine(input);
		}

	}	
}




		


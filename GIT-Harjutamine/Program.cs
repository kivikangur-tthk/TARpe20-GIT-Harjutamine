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


			AlamProgramm();
		}

        private static void AlamProgramm()
        {
            Console.WriteLine("Alamprogramm");
        }
    }
			Console.WriteLine("Tervitus Kasparilt.");
			Kasparfunk();
		}

		public static void Kasparfunk()
		{
			Console.WriteLine("function works");
		}
	}
}

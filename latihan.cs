using System;

namespace output_latihan
{
	class Program
	{
		static void Main(string[] args)
		{
			char c;
			int angka = 0;
			char huruf = 'c';
			string kalimat = "";
			try
			{
				Console.WriteLine("Masukan Angka :");
				kalimat = Console.ReadLine();
				angka = int.Parse(kalimat);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}


			try
			{
				Console.WriteLine("Enter a character : ");
				kalimat = Console.ReadLine();
				huruf = char.Parse(kalimat);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}


			try
			{
				Console.Write("Enter some words : ");
				kalimat = Console.ReadLine();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}


			Console.WriteLine("Hasilnya yang dinputkan : ");
			Console.WriteLine(angka);
			Console.WriteLine(huruf);
			Console.WriteLine(kalimat);
			Console.ReadKey(true);
		}
	}
}

using System;

namespace Donguler1
{
	class Program
	{
		static void Main(string[] args)
		{
			string kurs1 = "Yazılım Gelistirici Yetistirme Kampı";
			string kurs2 = "Programlamaya baslangic icin temel kurs";
			string kurs3 = "Java";

			string[] kurslar = new string[] { "Yazılım Gelistirici Yetistirme Kampı", "Programlamaya baslangic icin temel kurs", "Java", "C#" };


			
			for (int i = 0; i < kurslar.Length; i++)
			{
				Console.WriteLine(kurslar[i]);
			}

			Console.WriteLine("For bitti");

			foreach (string kurs in kurslar)
			{
				Console.WriteLine(kurs);
			}
			Console.WriteLine("sayfa sonu - footer");
		}
	}
}

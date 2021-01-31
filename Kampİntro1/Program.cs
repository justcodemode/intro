using System;

namespace Kampİntro1
{
	class Program
	{
		static void Main(string[] args)
		{

			//type safety - tip güvenliği
			//Do not repeat yourself - Kendini tekrarlama
			//değer tutucu, alias

			string kategoriEtiketi = "Kategoriler";
			int ugrenciSayisi = 32000;
			double faizOrani = 1.45;
			bool sistemeGirisYapmisMi = true;
			double dolarDun = 7.35;
			double dolarBugun = 7.45;

			if (dolarDun>dolarBugun)
			{
				Console.WriteLine("Azalış butonu");
			}
			else if (dolarDun<dolarBugun) 
			{
				Console.WriteLine("Azalış butonu");
			}
			else
			{
				Console.WriteLine("değişmediButonu");
			}
			if (sistemeGirisYapmisMi == true)
			{
				Console.WriteLine("Kullanıcı ayarları butonu");
			}
			else
			{
				Console.WriteLine("Giris yap butonu");
			}



			Console.WriteLine(kategoriEtiketi);
		

			

		}


	}

} 





			






/*
 * Utworzone przez SharpDevelop.
 * Użytkownik: GIL
 * Data: 10.09.2017
 * Godzina: 16:28
 * 
 * Do zmiany tego szablonu użyj Narzędzia | Opcje | Kodowanie | Edycja Nagłówków Standardowych.
 */
using System;

namespace Dyrdon_Adventure
{
	/// <summary>
	/// Description of Create.
	/// </summary>
	public class Create
	{
		
		public void CreateHero()
		{
			
			Console.WriteLine("Stwórz nowego bohatera");
			Console.Write("Podaj imie bohatera : ");
			string nazwaBohatera=Console.ReadLine();
			Console.Write("Podaj nazwisko bohatera : ");
			string nazwiskoBohatera=Console.ReadLine();
			Console.Clear();
			Console.WriteLine("Wybierz klasę postaci :");
			Console.WriteLine("1.Rycerz");
			Console.WriteLine("2.Łucznik");
			Console.WriteLine("3.Mag");
			string klasaPostaciWybor=Console.ReadLine();
			int result;
			bool klasaPostaci=int.TryParse(klasaPostaciWybor,out  result);
			if (!klasaPostaci||result>3) {
				result=1;
			}
			Player.PrzedstawSie(nazwaBohatera,nazwiskoBohatera,result);
		}
		
	}
}

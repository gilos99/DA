/*
 * Utworzone przez SharpDevelop.
 * Użytkownik: GIL
 * Data: 10.09.2017
 * Godzina: 09:26
 * 
 * Do zmiany tego szablonu użyj Narzędzia | Opcje | Kodowanie | Edycja Nagłówków Standardowych.
 */
using System;

namespace Dyrdon_Adventure
{
	/// <summary>
	/// Description of Enemy.
	/// </summary>
	public class Enemy:IEnemy
	{
		public Enemy(string imie, string nazwisko, int zycie)
		{
			this.Imie = imie;
			this.Nazwisko = nazwisko;
			this.Zycie = zycie;
			
		}
		public string Imie{get;set;}
		public string Nazwisko{get;set;}
		public int Zycie{get;set;}
		void IEnemy.Wypisz()
		{
			Console.WriteLine("{0} {1}",Imie,Nazwisko);
		}
	}
}

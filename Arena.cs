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
	/// Description of Arena.
	/// </summary>
	public class Arena
	{
		public IEnemy[] enemies =new Enemy[3];
		public Arena()
		{
			enemies[0]=new Enemy("Maciek","Bialon",200);
			enemies[1]=new Enemy("Szymon","Dyrda",300);
			enemies[2]=new Enemy("Daniel","Magical",350);
	
		}
		public int Combo{get;set;}
		public void EnemyWypisz()
		{
			for (int i = 0; i < enemies.Length; i++) {
				Console.Write("{0}.",i+1);
				enemies[i].Wypisz();
			}
		}
		public void Walka()
		{
			Console.WriteLine("Twój ruch :");
			Console.WriteLine("1.Uderz");
			Console.WriteLine("2.Unik");
			Console.WriteLine("3.Cios specjalny ({0})",Combo);
			
			
		}
		
	}
}

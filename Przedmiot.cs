/*
 * Created by SharpDevelop.
 * User: GIL
 * Date: 08.09.2017
 * Time: 17:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Dyrdon_Adventure
{
	/// <summary>
	/// Description of PrzedmiotS.
	/// </summary>
	public class Przedmiot:IPrzedmiot
	{
		public Przedmiot(string Nazwa,int Cena)
		{
			this.Nazwa=Nazwa;
			this.Cena=Cena;
			
		}
		public string Nazwa{get;set;}
		public int Cena{get;set;}
		void IPrzedmiot.Wypisz()
		{
			Console.WriteLine("{0}  {1}",Nazwa,Cena);
		}
	}
}

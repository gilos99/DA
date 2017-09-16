/*
 * Created by SharpDevelop.
 * User: GIL
 * Date: 08.09.2017
 * Time: 17:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Dyrdon_Adventure
{
	/// <summary>
	/// Description of Sklep.
	/// </summary>
	public class Sklep
	{
		public IPrzedmiot[] iteam=new Przedmiot[3];
		public Sklep()
		{
			iteam[0]=new Przedmiot("Miecz",200);
			iteam[1]=new Przedmiot("Dzida",100);
			iteam[2]=new Przedmiot("Mikstura Życia",50);
			
		}
			
		public void WriteIteams()
		{
		for (int i = 0; i < iteam.Length; i++) {
				Console.Write("{0}.",i+1);
					iteam[i].Wypisz();
		}
		}
		
		
	}
}

/*
 * Created by SharpDevelop.
 * User: GIL
 * Date: 07.09.2017
 * Time: 15:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Dyrdon_Adventure
{
	class Program
	{
		public static void Main(string[] args)
		{
			Create newPlayer=new Create();
			Console.WriteLine("|| DYRDON ADVENTURE || ");
			newPlayer.CreateHero();
			Mapa World=new Mapa();
			World.Universe();
			
			
			
			
			
			Console.ReadKey();
			Console.Clear();
			
			
			Console.ReadKey();
		}
	}
}
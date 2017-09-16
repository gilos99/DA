/*
 * Created by SharpDevelop.
 * User: GIL
 * Date: 07.09.2017
 * Time: 15:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Dyrdon_Adventure
{
	/// <summary>
	/// Description of Player.
	/// </summary>
	public static class Player
	{
		public static void PrzedstawSie(string _Name,string _LastName,int _Class)
		{
			
			Name=_Name;
			LastName=_LastName;
			Class=_Class;
			
			
			switch (_Class) {
				case 1:
					{
						Health=200;
						Klasa="Rycerz";
						Damage=30;
					}
					break;
					case 2:
					{
						Health=100;
						Klasa="Łucznik";
						Damage=40;
					}
					break;
					case 3:
					{
						Health=50;
						Klasa="Mag";
						Damage=50;
						}
					break;
					default:
					{}
					break;
			}
		}
		public static int Damage{get;set;}
		public static string Name{get;set;}
		public static string LastName{get;set;}
		public static int Class{get;set;}
		public static int Exp{get;set;}
		public static int Money{get;set;}
		public static int Health{get;set;}
		public static string Klasa{get;set;}
		public static void Stats()
		{
		
			Console.WriteLine("-------------------------------");
			Console.WriteLine("      {0} {1}",Name,LastName);
			Console.WriteLine("Klasa : {0}",Klasa);
			Console.WriteLine("Zdrowie : {0}",Health);
			Console.WriteLine("Doświadczenie : {0}",Exp);
			Console.WriteLine("Pieniądze : {0}",Money);
			Console.WriteLine("-------------------------------");
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
	}
		
	}
	 
}

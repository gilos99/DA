﻿/*
 * Created by SharpDevelop.
 * User: GIL
 * Date: 07.09.2017
 * Time: 19:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows;
namespace Dyrdon_Adventure
{
	/// <summary>
	/// Description of Mapa.
	/// </summary>
	public class Mapa
	{
		Sklep Shop=new Sklep();
		Arena Area=new Arena();
		
		Create heroCreator=new Create();
		
		
		public void Universe()
		{
			Player.Glod-=5;
			if (Player.Glod<=0) {
				Koniec();
			}
			Console.Clear();
			Player.Stats();
		Console.WriteLine("Gdzie chcesz isć?");
			Console.WriteLine("1.Miasto");
			string wyborUniverse=Console.ReadLine();
			int result;
			bool wyborUniverseInt=int.TryParse(wyborUniverse,out result);
			if (wyborUniverseInt && result==1) {
				switch (result) {
				case 1:
					{
						
						Miasto();
					}
					break;
				default:
					break;
			}
			}
			else if (!wyborUniverseInt||result>1) {
				Console.WriteLine("Zły klawisz alfanabeto! ");
				Console.ReadKey();
				Universe();
			}
			
			
		}
		public void Miasto()
		{
			Player.Glod-=5;
			if (Player.Glod<=0) {
				Koniec();
			}
			Area.enemies[0].Zycie=200;
			Area.enemies[1].Zycie=300;
			Console.Clear();
			Player.Stats();
			Console.WriteLine("Jesteś w mieście! Co chcesz zrobić?");
			Console.WriteLine("1.Idź do sklepu");
			Console.WriteLine("2.Idź na arenę");
			Console.WriteLine("3.Idź na siłkę");
			Console.WriteLine("4.Wróć");
			string wyborMiastoString=Console.ReadLine();
			int result;
			bool wyborMiastoInt=int.TryParse(wyborMiastoString,out result);
			if (wyborMiastoInt&&result<=4) {
			switch (result) {
				case 1:
					{
						Sklep();
					}
					break;
				case 2:
					{
						Arena();
					}
					break;
				case 3:
					{
						Silownia();
					}
					break;
					case 4:
					{
						Universe();
					}
					break;
				default:
					break;
						
			}
				
			
			}
			else if (!wyborMiastoInt||result>4) {
				Console.WriteLine("Zły klawisz alfanabeto!");
				Console.ReadKey();
				Miasto();
				}
			
		}
		public void Silownia()
		{
			Player.Glod-=5;
			if (Player.Glod<=0) {
				Koniec();
			}
			Console.Clear();
			Player.Stats();
			Console.WriteLine("Jesteś na siłowni. Możesz tutaj zwiększyć masę mięśniową");
			Console.WriteLine("1.Ćwicz (50$)");
			Console.WriteLine("2.Wróć");
			string wyborSilkaString=Console.ReadLine();
			int result;
			bool wyborSilkaBool=int.TryParse(wyborSilkaString,out result);
			switch (result) {
				case 1:
					if (Player.Money>=20) {
						Player.Money-=20;
						Player.Damage+=15;
						Console.WriteLine("Dostałeś + 10 siły!");
						Console.ReadKey();
						Silownia();
					}
					else	if (Player.Money<20) {
						Console.WriteLine("Nie dla psa!");
						Console.ReadKey();
						Silownia();
					}
					break;
				case 2:
					Miasto();
					break;
				default:
					{
						Console.WriteLine("Zły klawisz alfanabeto!");
						Console.ReadKey();
						Silownia();
					}
					break;
			}
			if (!wyborSilkaBool) {
				Console.WriteLine("Zły klawisz alfanabeto!");
						Console.ReadKey();
						Silownia();
			}
		}
		public void Arena()
		{
			Player.Glod-=5;
			if (Player.Glod<=0) {
				Koniec();
			}
			Console.Clear();
			Player.Stats();
			Console.WriteLine("Jesteś w arenie. Możesz tutaj walczyć.");
			Area.EnemyWypisz();
			Console.WriteLine("{0}.Wróć do miasta",Area.enemies.Length+1);
			string wyborArenaString=Console.ReadLine();
			int result;
			bool wyborArenaBool=int.TryParse(wyborArenaString,out result);
			if (wyborArenaBool&&result<=4) {
				if (result==Area.enemies.Length+1) {
						Miasto();
				
			}
			switch (result) {
				case 1:
					{
						Fight(Area.enemies[0]);
					}
					break;
				case 2:
					{
						Fight(Area.enemies[1]);	
					}
					break;
					case 3:
					{
						Fight(Area.enemies[2]);	
					}
					break;
				default:
					break;
			}
			}
			else if (!wyborArenaBool||result>4) {
				Console.WriteLine("Zły klawisz alfanabeto!");
				Console.ReadKey();
				Arena();
				}
			
		}
		public void Koniec()
		{
			Console.Clear();
			Console.WriteLine("Przegrałeś! Spierdalaj");
			Console.ReadKey();
			Environment.Exit(0);
		}
		public void Fight(IEnemy enemy)
		{
			
			if (Player.Glod<=0) {
				Koniec();
			}
			IEnemy wrog=enemy;
			if (enemy.Zycie<=0) {
				if (enemy==Area.enemies[0]) {
					Win(100);
				}
				if (enemy==Area.enemies[1]) {
					Win(200);
				}
				if (enemy==Area.enemies[2]) {
					Win(300);
				}
			}
			Console.Clear();
			Player.Stats();
			Console.Write("{0} {1} vs ",Player.Name,Player.LastName);
			
			wrog.Wypisz();
			Area.Walka();
			string walkaWyborString=Console.ReadLine();
			int result;
			bool walkaWyborBool=int.TryParse(walkaWyborString,out result);
			if (walkaWyborBool&&result<=4) {
					switch (result) {
				case 1:
					{
						wrog.Zycie-=Player.Damage;
						if (Player.Health>0) {
						Player.Health-=10;
						}
					else if (Player.Health<=0) {
						Koniec();
			
						}
					}
					break;
				case 2:
					{
						
					}
					break;
				case 3:
					{
						if (Area.Combo>0) {
							wrog.Zycie-=100;
							Area.Combo--;
						}
						else if (Area.Combo<=0) {
							Console.WriteLine("Nie możesz użyć");
							Console.ReadKey();
						}
						
					if (Player.Health>0) {
						Player.Health-=10;
						}
					else if (Player.Health<=0) {
						Koniec();
			
						}
					}
					break;
				default:
					break;
			}
			
			}
			else if (!walkaWyborBool||result>4) {
				Console.WriteLine("Zły klawisz alfanabeto!");
				Console.ReadKey();
				
				}
		
			
			
			Fight(wrog);
		}
		public void Win(int Add)
		{
			Console.Clear();
			Console.WriteLine("Wygrałeś!");
			Console.WriteLine("Otrzymałeś  cios specjalny ");
			Area.Combo+=1;
			Player.Exp+=Add;
			Player.Money+=(Add+(Add/2));
			Console.ReadKey();
			Miasto();
			
		}
		public void Sklep()
		{
			
			if (Player.Glod<=0) {
				Koniec();
			}
			Console.Clear();
			Player.Stats();
			Console.WriteLine("Jesteś w sklepie! Co chcesz kupić?");
			Shop.WriteIteams();
			Console.WriteLine("{0}.Wróć do  miasta",Shop.iteam.Length+1);
			string wyborSklepString=Console.ReadLine();
			int result;
			bool wyborSklepBool=int.TryParse(wyborSklepString,out result);
			if (wyborSklepBool&&result<=5) {
				if (result==(Shop.iteam.Length+1)) {
				Miasto();
			}
			switch (result) {
				case 1:
					{
					if (Player.Money>=200) {
							Player.Money-=200;
							Console.WriteLine("Kupiłeś miecz");
							Player.Damage=80;
					}
						else if(Player.Money<200)
						{
						Console.WriteLine("Nie stać cię na to!");
						}
						Console.ReadKey();
						Sklep();
					}
					break;
					case 2:
					if (Player.Money>=100) {
							Player.Money-=100;
							Console.WriteLine("Kupiłeś dzidę");
							Player.Damage=60;
					}
					else if(Player.Money<100)
						{
						Console.WriteLine("Nie stać cię na to!");
						}
					Console.ReadKey();
					Sklep();
					break;
					case 3:
					{
						if (Player.Money>=50) {
							Player.Money-=50;
							Console.WriteLine("Kupiłeś Miksturę Życia");
							Player.Health+=50;
						}
						else if(Player.Money<50)
						{
						Console.WriteLine("Nie stać cię na to!");
						}
						
						Sklep();
					}
					break;
				case 4:
					{
					if (Player.Money>=20)
						{
							Player.Money-=20;
							Player.Glod=100;
							Console.WriteLine("Kupiłeś jedzenie");
							Console.ReadKey();
							
						}
					else if(Player.Money<20) {
						Console.WriteLine("Nie stać cię na to");
						Console.ReadKey();
					}
					
					Sklep();
					}
					break;
					default :
						break;
			}
			}
			else if (!wyborSklepBool||result>5) {
				Console.WriteLine("Zły klawisz alfanabeto!");
				Console.ReadKey();
				Sklep();
				}
			
			
		}
		
	}
}

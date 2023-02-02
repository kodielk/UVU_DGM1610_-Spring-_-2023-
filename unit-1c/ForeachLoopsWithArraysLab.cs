using System;
					
public class Program
{
	public static void Main()
	{
		string[] champions = {"Swain", "Galio", "Annie", "Thresh", "Rek'Sai", "Vi"};
		Console.WriteLine("I can play " + champions.Length + " champions.");
		foreach(var champion in champions){
			Console.WriteLine("I love playing " + champion + ".");
		}

	}
}
using System;
					
public class Program
{
	public static void Main()
	{
		string[] classTypes = {"peasant", "peasant", "peasant", "king"};
		foreach (var classType in classTypes){
			Console.WriteLine(classType);
		}
	}
}
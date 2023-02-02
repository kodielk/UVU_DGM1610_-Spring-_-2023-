using System;
					
public class Program
{
	public static void Main()
	{
		string[] classTypes = {"peasant", "peasant", "peasant", "king"};
		
		for(var i = 0; i < classTypes.Length; i++){
			classTypes[i] = "Zombie";
		}
			
		foreach (var classType in classTypes){
			Console.WriteLine(classType);
		}
		Console.WriteLine("There are " + classTypes.Length + " people still alive.");
	}
}
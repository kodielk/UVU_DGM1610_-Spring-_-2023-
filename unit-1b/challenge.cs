using System;
					
public class Program
{
    public float powerLevel = 1000.0f;
	public GokuStatus gokuStatus;
	
	public void Main()
	{
		gokuStatus = new GokuStatus();
		gokuStatus.currentState = GokuStatus.Status.NotYelling;
		gokuStatus.CheckState();
		gokuStatus.CheckPowerlevel(powerLevel);
	}
}

public class GokuStatus{
	public enum Status {
		Yelling,
		NotYelling
	}
	
	public Status currentState = Status.Yelling;
	
	public void CheckState() {
		switch (currentState) {
			case Status.Yelling:
				powerLevel == 9000.1f;
				Console.WriteLine("Goku starts to yell loudly, and the earth shakes around him.");
				break;
			case Status.NotYelling:
				powerLevel == 9000.0f;
				Console.WriteLine("Goku stands and stares at Vegeta, menacingly");
				break;
		}
	}
	public void CheckPowerlevel(int powerLevel)
	{
		if (powerLevel > 9000)
		{
			Console.WriteLine("His power level... It's over 9000! There's no way that can be right!");
		}
		else
		{
			Console.WriteLine("Pfft. What a wimp.");
		}
	}
}


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

}


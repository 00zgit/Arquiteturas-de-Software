//Client code somewhere
Factory factory = new();
Console.WriteLine(factory.GetAClientObject("First")); // Client does not know about the types of factory objects
Console.WriteLine(factory.GetAClientObject("Second"));


public class FirstClientObject{ }
public class SecondClientObject{ }
// Other types to be factored (client does not know about them)


public class Factory // Factory
{
	public ClientFactory() { }

	public ClientObject GetAClientObject(string characteristic)
	{
		if(characteristic == "First")
		{
			return new FirstClientObject();
		}
		else if(characteristic == "Second")
		{
			return new SecondClientObject();
		}
		//...
	}
}

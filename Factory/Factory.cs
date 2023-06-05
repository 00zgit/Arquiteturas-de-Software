//Client code somewhere
Factory factory = new();
Console.WriteLine(factory.GetAClientObject("First")); // Client does not know about the types of factory objects
Console.WriteLine(factory.GetAClientObject("Second"));
//$end


public class FirstClientObject : IClientObject{ }
public class SecondClientObject : IClientObject{ }
// Other types to be factored (client does not know about them)


public class Factory
{
	public Factory() { }

	public IClientObject GetAClientObject(string characteristic)
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

interface IClientObject
{
	// Setup any configuration needed
}

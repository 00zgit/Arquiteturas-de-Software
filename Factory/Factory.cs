//Client code somewhere
Factory factory = new();
factory.GetAClientObject("First"); // Client does not know about the types of factory objects
factory.GetAClientObject("Second");
//$end


public class FirstClientObject : IClientObject{ }
public class SecondClientObject : IClientObject{ }
// ...


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

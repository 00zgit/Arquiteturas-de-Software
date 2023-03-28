using System;

public class Program
{
	public static void Main()
	{
		Proxy proxy = new();
		Client client = new(proxy);
		Console.WriteLine(client.__BDBehindProxy.getSomethingBehindProxy());
		Console.WriteLine();
		Console.WriteLine(client.__BDBehindProxy.getSomethingBehindProxy());
	}
}

public class Client
{
	public IBD __BDBehindProxy;
	
	public Client(IBD implementer)
	{
		this.__BDBehindProxy = implementer;
	}
}

public interface IBD
{
	string getSomethingBehindProxy();
}

public class Proxy : IBD
{
	public BD DatabaseData = new();
	public string Something { get; private set; }
	
	public Proxy() { }
	
	public string getSomethingBehindProxy()
	{
		if(this.Something == null)
		{
			Console.WriteLine("\nUpdating content on database...");
			this.Something = DatabaseData.getSomethingBehindProxy();
		}
		
		return this.Something;
	}
}

public class BD : IBD
{
	public BD() { }
	
	public string getSomethingBehindProxy()
	{
		return "Content in database behind proxy";
	}
}
using System;
					
public class Application
{
	public static void Main()
	{
		Decorator stack = new();
		stack = new Decorator2(stack);
		stack = new Decorator3(stack);
	}
}

public class Decorator
{
	public decimal Sum = 0;
	
	public Decorator() { }
	
	public decimal getAll()
	{
		return this.Sum;
	}
}

public class BaseDecorator : Decorator
{
	public Decorator Wrapper;
	
	public BaseDecorator(Decorator decorator) { this.Wrapper = decorator; }
	
	public decimal getAll()
	{
		return this.Sum;
	}
}

public class Decorator2 : BaseDecorator
{
	public Decorator2(Decorator decorator) : base(decorator) { }
	
	public decimal getAll()
	{
		return this.Sum + 20;
	}
}
public class Decorator3 : BaseDecorator
{
	public Decorator3(Decorator decorator) : base(decorator) { }
	
	public decimal getAll()
	{
		return this.Sum + 30;
	}
}
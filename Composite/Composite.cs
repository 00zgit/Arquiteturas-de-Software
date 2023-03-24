using System;
using System.Collections.Generic;

					
public class Program
{
	public static void Main()
	{
				
		Leaf leaf1 = new Leaf();
		Leaf leaf2 = new Leaf();
		Leaf leaf3 = new Leaf();
		
		Composite root = new Composite();
		root.AddIComponentImplementers(leaf1);
		root.AddIComponentImplementers(leaf2);
		
		Composite composite2 = new Composite();
		composite2.AddIComponentImplementers(leaf3);
		
		root.AddIComponentImplementers(composite2);
		
		Console.WriteLine(root.execute());
	}
}


public interface IComponent
{
	int execute();
}

public class Leaf : IComponent
{
	public int LeafProperty = 10;
	
	public int execute()
	{
		return this.LeafProperty;
	}
}

public class Composite : IComponent
{
	private List<IComponent> Components = new List<IComponent>();
	
	public Composite() { }
	
	public void AddIComponentImplementers(IComponent implementer)
	{
		Components.Add(implementer);
	}
	
	public int execute()
	{
		int valorTotal = 0;
		
		foreach(var implementer in Components)
		{
			valorTotal += implementer.execute();
		}
		
		return valorTotal;
	}
}

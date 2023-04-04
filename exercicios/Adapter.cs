using System;
					
public class Program
{
	public static void Main()
	{
		AdapterBD adapter = new();
		Controller ct = new(adapter);
		ct.BuscarPedido();
	}
}


public class Controller
{
	AdapterBD Adapter;
	
	public Controller(AdapterBD adapter)
	{
		Adapter = adapter;
	}
	
	public string BuscarPedido()
	{
		return Adapter.BuscarPedidos();
	}
}


public interface IBD
{
	string BuscarPedidos();
}

public class AdapterBD : IBD
{
	public string BuscarPedidos()
	{
		PedidoBDMongoDB mongo = new();
		return mongo.BuscarPedidos();
	}
}
public class PedidoBDMySQL : IBD
{
	public string BuscarPedidos()
	{
		return "Pedidos no MySQL";
	}
}
public class PedidoBDMongoDB : IBD
{
	public string BuscarPedidos()
	{
		return "Pedidos no MongoDB";
	}
}
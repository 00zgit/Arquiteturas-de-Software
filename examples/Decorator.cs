public class Program
{
	public static void Main()
	{
		Computador c = new();
        if(c.HasPlacaDeVideo)
        {
            c = new PlacaDeVideo(c);
        }
        if(c.HasRam8Gb)
        {
            c = new Ram8Gb(c);
        }
        if(c.Has1TBSSD)
        {
            c = new SSD1TB(c);
        }

        Console.WriteLine($"Total do pedido: {c.getAll()}");
	}
}


public class Computador
{
	public decimal Valor = 3000;
    public bool HasPlacaDeVideo = true;
    public bool HasRam8Gb = true;
    public bool Has1TBSSD = true;

    public decimal getAll() {
        return this.Valor;
    }

	public Computador() { }
}


public class BaseDecorator : Computador
{
	public Computador Wrapper;
	
	public BaseDecorator(Computador decorator) { this.Wrapper = decorator; }
	
    public decimal getAll()
	{
		return this.Wrapper.getAll();
	}
}


public class PlacaDeVideo : BaseDecorator
{
	public PlacaDeVideo(Computador decorator) : base(decorator) { }
	
    public decimal Valor = 2000;

	public decimal getAll()
	{
		return base.getAll() + this.Valor;
	}
}
public class Ram8Gb : BaseDecorator
{
	public Ram8Gb(Computador decorator) : base(decorator) { }
	
    public decimal Valor = 200;

	public decimal getAll()
	{
		return base.getAll() + this.Valor;
	}
}
public class SSD1TB : BaseDecorator
{
    public SSD1TB(Computador decorator) : base(decorator) { }

    public decimal Valor = 400;
	
	public decimal getAll()
	{
		return base.getAll() + this.Valor;
	}
}
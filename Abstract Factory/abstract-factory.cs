//Client code (or input) somewhere
WinFactory win = new(); 
MacFactory mac = new();
LinuxFactory lnx = new();
Application app = new(win);

Itarget target = app.Factory.Create();
target.DoSomething();

public class Application
{
    private static GUIFactory Factory;
    private static ITarget WinTarget;
    private static ITarget MacTarget;
    private static ITarget LinuxTarget;

    public Application(GUIFactory gf)
    {
        Factory = gf;
    }
}

public interface GUIFactory
{
    ITarget Create();
}

public interface ITarget
{
    void DoSomething();
}

public class WindowsFactory : GUIFactory
{
    public Target Create()
    {
        return new WinTarget();
    }
}
public class WinTarget : ITarget
{
    public void DoSomething()
    {
        Console.WriteLine("you did something at windows");
        //...
    }
}
public class MacFactory : GUIFactory
{
    public Target Create()
    {
        return new MacTarget();
    }
}
public class MacTarget : ITarget
{
    public void DoSomething()
    {
        Console.WriteLine("you did something at macos");
        //...
    }
}
public class LinuxFactory : GUIFactory
{
    public Target Create()
    {
        return new LinuxTarget();
    }
}
public class LinuxTarget : ITarget
{
    public void DoSomething()
    {
        Console.WriteLine("you did something at linux");
        //...
    }
}
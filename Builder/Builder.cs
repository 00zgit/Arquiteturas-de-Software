public class Target // The intent is that this class should never change, with Properties that may vary
{
    public List<string> MyListOfProperties = new();

    public JustPrintMyProperties()
    {
        Console.WriteLine(Properties.foreach (var item in collection)
        {
            item
        });
    }
}

public interface ITargetBuilder // The intent is to have a single interface...
{
    ITargetBuilder doSomething1();
    ITargetBuilder doSomething2();
    ITargetBuilder doSomething3();
    ITargetBuilder doSomething4();
    ITargetBuilder doSomething5();
    //to infinite and beyond
}

public class TargetBuilder : ITargetBuilder // ... and many builders
{
    public Target Target = new();

    public ITargetBuilder doSomething1()
    {
        Target.MyListOfProperties.Add("doSomething1");
    }
    public ITargetBuilder doSomething2()
    {
        Target.MyListOfProperties.Add("doSomething2");
    }
    //...
}

public class Director
{
    public ITargetBuilder Builder;

    public Director(ITargetBuilder target)
    {
        Builder = target;
    }

    public Target BuildATarget()
    {
        Builder.doSomething1();
        Builder.doSomething2();
    }
    public Target BuildAnotherTypeOfTarget()
    {
        Builder.doSomething2();
        Builder.doSomething5();
    }
}
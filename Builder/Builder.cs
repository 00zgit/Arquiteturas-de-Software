public class Target // The intent is that this class should never change, with Properties that may vary
{
    public List<string> MyListOfProperties = new();

    public JustPrintMyProperties()
    {
        // print MyListOfProperties
    }
}

public interface ITargetBuilder // The intent is to have a single interface...
{
    void doSomething1();
    void doSomething2();
    void doSomething3();
    void doSomething4();
    void doSomething5();
    //to infinite and beyond
}

public class TargetBuilder : ITargetBuilder // ... and many builders
{
    public Target Target = new();

    public void doSomething1()
    {
        Target.MyListOfProperties.Add("doSomething1");
    }
    public void doSomething2()
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
        return Builder;
    }
    public Target BuildAnotherTypeOfTarget()
    {
        Builder.doSomething2();
        Builder.doSomething5();
        return Builder;
    }
}


/* Client code somewhere */
Director d = new(new Target());
var target = d.BuildATarget();
target.JustPrintMyProperties();
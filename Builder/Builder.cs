class Target1 // The creation of this type of class should be hidden from client
{
    public List<string> MyListOfProperties = new();

    public void JustPrintMyProperties()
    {
        // print MyListOfProperties
    }
}

interface ITargetBuilder // The intent is to have a single interface...
{
    void doSomething1();
    void doSomething2();
    void doSomething3();
    void doSomething4();
    void doSomething5();
    //to infinite and beyond
}

class TargetBuilder1 : ITargetBuilder // ... and many builders ...
{
    public Target1 Target = new();

    public void doSomething1()
    {
        Target1.MyListOfProperties.Add("doSomething1");
    }
    public void doSomething2()
    {
        Target1.MyListOfProperties.Add("doSomething2");
    }
    //...
    public void doSomething5()
    {
        Target1.MyListOfProperties.Add("doSomething5");
    }

    public Target1 GetResult() // ... and which one will build a different Target.
    {
        return this.Target;
    }
}

class Director
{
    public ITargetBuilder Builder;

    public Director(ITargetBuilder builder)
    {
        Builder = builder;
    }


    // Example:
    public void BuildTarget1()
    {
        Builder.doSomething1();
        Builder.doSomething2();
    }
    public void BuildTarget2()
    {
        Builder.doSomething2();
        Builder.doSomething5();
    }
    // But a better solution would be a single
    // method that implements type comparison
    //eg.: by parameter of type string or integer.
}


/* Client code somewhere */
TargetBuilder1 b = new();
Director d = new(b);

d.BuildTarget1();
Target1 t = b.GetResult();

t.JustPrintMyProperties();

// or ...

TargetBuilder2 b = new();
Director d = new(b);

d.BuildTarget2();
Target2 t = b.GetResult();

t.JustPrintMyProperties();
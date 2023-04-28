public class Program
{
    public static void Main()
    {
        FlyweightFactory fac = new(new ObjectType1(), new ObjectType2(), new ObjectType3());
        // get SharedObjects by a specific property of ObjectTypes...
    }
}

public class FlyweightFactory
{
    protected List<SharedObject> SharedObjects = new();

    public FlyweightFactory(params object objs)
    {
        SharedObjects.Add(objs)
    }
}

public class SharedObject
{
///
}

public class ObjectType1 : SharedObject
{
///
}

public class ObjectType2 : SharedObject
{
///
}

public class ObjectType3 : SharedObject
{
///
}
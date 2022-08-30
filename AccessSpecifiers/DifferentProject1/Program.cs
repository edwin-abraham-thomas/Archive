// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class ClassInDifferentProject1: AccessSpecifiers
{
    public static void Main()
    {
        var obj = new ClassInDifferentProject1();
        obj.PublicProp = "";
        //obj.PrivateProp = "";
        obj.ProtectedProp = "";
        //obj.InternalProp = "";
        obj.ProtectedInternalProp = "";
        obj.PublicMethod();
        //obj.PrivateMethod();
        obj.ProtectedMethod();
        //obj.InternalMethod();
        obj.ProtectedInternalMethod();
    }
}

public class ClassInDifferentProject2
{
    public static void Main()
    {
        var obj = new AccessSpecifiers();
        obj.PublicProp = "";
        //obj.PrivateProp = "";
        //obj.ProtectedProp = "";
        //obj.InternalProp = "";
        //obj.ProtectedInternalProp = "";
        obj.PublicMethod();
        //obj.PrivateMethod();
        //obj.ProtectedMethod();
        //obj.InternalMethod();
        //obj.ProtectedInternalMethod();
    }
}

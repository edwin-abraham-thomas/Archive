// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var childObj = new ChildClass();
childObj.PublicProp = "";
//childObj.PrivateProp = "";
//childObj.ProtectedProp = "";
childObj.InternalProp = "";
childObj.ProtectedInternalProp = "";
childObj.PublicMethod();
//childObj.PrivateMethod();
//childObj.ProtectedMethod();
childObj.InternalMethod();
childObj.ProtectedInternalMethod();

var accessSpecifier = new AccessSpecifiers();
accessSpecifier.PublicProp = "";
//accessSpecifier.PrivateProp = "";
//accessSpecifier.ProtectedProp = "";
accessSpecifier.InternalProp = "";
accessSpecifier.ProtectedInternalProp = "";
accessSpecifier.PublicMethod();
//accessSpecifier.PrivateMethod();
//accessSpecifier.ProtectedMethod();
accessSpecifier.InternalMethod();
accessSpecifier.ProtectedInternalMethod();




public class AccessSpecifiers
{
    public string PublicProp { get; set; }
    private string PrivateProp { get; set; }
    protected string ProtectedProp { get; set; }
    internal string InternalProp { get; set; }
    protected internal string ProtectedInternalProp { get; set; }

    public void PublicMethod()
    {
        Console.WriteLine("Public Method");
    }
    private void PrivateMethod()
    {
        Console.WriteLine("Private Method");
    }
    protected void ProtectedMethod()
    {
        Console.WriteLine("Protected Method");
    }
    internal void InternalMethod()
    {
        Console.WriteLine("Internal Method");
    }
    protected internal void ProtectedInternalMethod()
    {
        Console.WriteLine("Protected Internal Method");
    }

    public static void Main()
    {
        var obj = new AccessSpecifiers();
        obj.PublicProp = "";
        obj.PrivateProp = "";
        obj.ProtectedProp = "";
        obj.InternalProp = "";
        obj.ProtectedInternalProp = "";
        obj.PublicMethod();
        obj.PrivateMethod();
        obj.ProtectedMethod();
        obj.InternalMethod();
        obj.ProtectedInternalMethod();
    }
}

public class ChildClass: AccessSpecifiers
{
    public static void Main()
    {
        var obj = new ChildClass();
        obj.PublicProp = "";
        //obj.PrivateProp = "";
        obj.ProtectedProp = "";
        obj.InternalProp = "";
        obj.ProtectedInternalProp = "";
        obj.PublicMethod();
        //obj.PrivateMethod();
        obj.ProtectedMethod();
        obj.InternalMethod();
        obj.ProtectedInternalMethod();
    }
}

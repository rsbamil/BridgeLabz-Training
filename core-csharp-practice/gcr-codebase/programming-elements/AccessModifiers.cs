using System;
class Parent
{
    // Protected Method
    protected void ProtectedMethod()
    {
        Console.WriteLine("This is a protected method.");
    }
    // Protected Internal Method
    protected internal void ProtectedInternalMethod()
    {
        Console.WriteLine("This is a protected internal method.");
    }
    // Private Protected Method
    private protected void PrivateProtectedMethod()
    {
        Console.WriteLine("This is a private protected method.");
    }
}

class Child : Parent
{
    public void Show()
    {
        ProtectedMethod(); 
        ProtectedInternalMethod();
        PrivateProtectedMethod();
    }
    
}
class Private
{
    private void PrivateMethod()
    {
        Console.WriteLine("This is a private method.");
    }

    public void Show()
    {
        PrivateMethod(); 
    }
}
class Internal
{
    internal void InternalMethod()
    {
        Console.WriteLine("This is an internal method.");
    }
}
class AccessModifiers{
    public static void PublicMethod(){
        Console.WriteLine("This is a public method.");
    }
    protected static void ProtectedMethod(){
        Console.WriteLine("This is a protected method.");
    }
    static void Main(){
        PublicMethod();
        Child c=new Child();
        c.Show();
        Private s=new Private();
        s.Show();
        Internal i=new Internal();
        i.InternalMethod();
    }
}
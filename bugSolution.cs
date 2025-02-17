public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize MyProperty
    public ExampleClass(int initialValue)
    {
        MyProperty = initialValue;
    }

    public void MyMethod()
    {
        // MyProperty is now initialized before being accessed
        int value = this.MyProperty;
        Console.WriteLine(value);
    }
} 
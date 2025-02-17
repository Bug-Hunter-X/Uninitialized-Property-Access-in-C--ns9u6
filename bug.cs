public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that might not be initialized
        int value = this.MyProperty; 
        // Using the uninitialized value may lead to unexpected behavior or exceptions
        Console.WriteLine(value); 
    }
}
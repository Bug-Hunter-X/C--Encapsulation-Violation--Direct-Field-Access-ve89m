public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        // Accessing a field directly without using the property, which breaks encapsulation
        _myField = 10; 
    }
}
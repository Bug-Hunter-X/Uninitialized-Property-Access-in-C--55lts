public class ExampleClass{
    public int MyProperty { get; set; }

    public void MyMethod() {
        //This is a potential bug if MyProperty is not initialized before use
        int result = MyProperty * 2; //Exception if MyProperty is not initialized
    }
}
class program{
    static void Main(){
        int num;
        string message;
        MethodWithOut(out num, out message);
        console.WriteLine($"Number: {num}")
        console.WriteLine($"Message: {message}");
    }
    static void MethodWithOut(out int number, out string msg)
    {
        number = 10;
        msg = "Hello form Hello World";
    }
}
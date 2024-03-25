class Program
{ 
    /*static void Square(int a , int b)
    { 
        a = a + b;
        b += 1;
        a = a * b;
        b *=b;
        Console.WriteLine(a + " " + b);
    
    }*/
    static void Main(string[] args) {
        int num1 = 5;
        int num2 = 10;
        Console.WriteLine(num1 + " " + num2);
        Square(num1, num2);
        Console.WriteLine(num1 + " " + num2);
        Console.WriteLine("Press enter to Exit...")
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ReadLine();
    }
}

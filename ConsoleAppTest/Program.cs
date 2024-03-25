class Program
{ 
    static void Square(int a , int b)
    { 
        a = a + b;
        b += 1;
        a = a * b;
        b *=b;
        Console.WriteLine(a + " " + b);
    
    }

}

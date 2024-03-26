using System;

class Program
{
    static void Main(string[] args)
    {
        string[] dogs = new string[] { "Thomas", "Snow", "Ali", "Axel", "Harry" };
        IEnumerable<string> ExceptSnow =
            from dog in dogs
            where dog != "Snow"
            select dog;
        foreach (string dog in ExceptSnow)
        {
            Console.WriteLine(dog);
        }
    }
}
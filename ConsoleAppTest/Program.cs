using System;
using System.Data.SqlClient;
class Program
{
    static void Main(string[] args)
    {
        /*
        string[] dogs = new string[] { "Thomas", "Snow", "Ali", "Axel", "Harry" };
        IEnumerable<string> ExceptSnow =
            from dog in dogs
            where dog != "Snow"
            select dog;
        foreach (string dog in ExceptSnow)
        {
            Console.WriteLine(dog);
        }
        */

        IList<Animal> animals = new List<Animal>()
        {
            new Dragon("Gontran"),
            new Dragon("Dragon blanc aux yeux bleus", "Rare"),
            new Griffin("Peter"),
            new Griffin("Buck","Rare")
        };

        var commonest = from common in animals
                     where common.Rarity != "Rare"
                     orderby common.Name descending
                     select common;
                     

        foreach (Animal common in commonest)
        {
            Console.WriteLine(common.Name);
        }

        Eagle eagle = new Eagle("Aigle Royal","Rare");
        Bird bird = new Bird("Woody");
        bird.sleep();
        bird.move();
        eagle.sleep();
        eagle.move();
        eagle.Fly();
        bird.Fly();
    }
}
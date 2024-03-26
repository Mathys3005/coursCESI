using System;
using System.Xml.Linq;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Griffin : Animal
{
    Griffin()
    {
        Name = "griffin";
    }
    public Griffin(string name)
    {
        Name = name;
    }
    public override void move()
    {
        Console.WriteLine(this.Name + " le griffin qui bouge");
    }
    public new void sleep()
    {
        Console.WriteLine(this.Name + " le griffin dort");
    }
}
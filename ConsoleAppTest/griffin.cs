using System;
using System.Xml.Linq;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Griffin : Animal, IFly
{
    Griffin()
    {
        this.Name = "griffin";
    }
    public Griffin(string name, string rarity)
    {
        this.Name = name;
        this.Rarity = rarity;
    }
    public Griffin(string name)
    {
        this.Name = name;
    }
    public override void move()
    {
        Console.WriteLine(this.Name + " le griffin qui bouge");
    }
    public new void sleep()
    {
        Console.WriteLine(this.Name + " le griffin dort");
    }
    public void Fly()
    {
        Console.WriteLine(this.Name + " le griffin vole");
    }
}
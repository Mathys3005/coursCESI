using System;

public class Dragon : Animal, IPilotage, IFly
{
    Dragon()
    {
        this.Name = "dragon";
    }
    public Dragon(string name, string rarity)
    {
        this.Name = name;
        this.Rarity = rarity;
    }

    public Dragon(string name)
    {
        this.Name = name;
    }
    public override void move()
    {
        Console.WriteLine(this.Name + " le dragon bouge");
    }
    public void moove()
    {
        Console.WriteLine( this.Name + " le dragon bouge mais en pilotant");
    }
    public override void sleep()
    {
        Console.WriteLine(this.Name + " le dragon dort");
    }

    public void Fly()
    {
        Console.WriteLine(this.Name + " le dragon vole");
    }
}
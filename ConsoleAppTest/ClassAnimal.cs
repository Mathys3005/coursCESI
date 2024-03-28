using System;
using System.Globalization;

public abstract class Animal
{
	public string Name { get; protected set; }
	public string Rarity { get; set; }
	public virtual void move(){}

	public virtual void sleep(){}

	public void display()
	{
        Console.WriteLine("Name: " + Name + " Rarity: " + Rarity);
    }
}

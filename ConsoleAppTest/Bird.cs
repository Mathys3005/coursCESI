using System;

public class Bird : Animal, IFly
{
	public Bird(){}

	public Bird(string Name, string Rarity)
	{
		this.Name = Name;
		this.Rarity = Rarity;
	}

	public Bird(string Name)
	{
		this.Name=Name;
	}

	public virtual void Fly()
	{
		Console.WriteLine(this.Name + " flap flap fly et pouf il a crash");
	}

	public override void move()
	{
		Console.WriteLine(this.Name + " bouge comme un oiseau");
	}

	public override void sleep()
	{
		Console.WriteLine(this.Name + " dodo");
	}
}

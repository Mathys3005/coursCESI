using System;
using System.Globalization;

/// <summary>
/// Summary description for Class1
/// </summary>
abstract class Animal
{
	protected string espece;
	protected Animal(string espece)
	{
		this.espece = espece;
	}
	protected Animal()
	{
		this.espece = "Inconnu";
	}

	public virtual void move()
    {
        Console.WriteLine("L'animal se déplace");
    }

	public virtual void sleep()
    {
        Console.WriteLine("L'animal dort");
    }
}

class Griffin : Animal

{
	public Griffin(string espece) : base(espece)
    {
    }

    public override void move()
	{
        Console.WriteLine("Le Griffin vole");
    }

    public new void sleep()
	{
        Console.WriteLine("Il dort dans un nid");
    }

}

class Dragon : Animal
{
    public Dragon(string espece) : base(espece)
    {
        this.espece = espece;
    }

    public override void move()
    {
        Console.WriteLine("Le dragon vole");
    }

    public new void sleep()
    {
        Console.WriteLine("Il dort dans une grotte");
    }
}
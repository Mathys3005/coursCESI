using System;
using System.Globalization;

/// <summary>
/// Summary description for Class1
/// </summary>
public abstract class Animal
{
	public string Name { get; protected set; }
	public virtual void move(){}

	public virtual void sleep(){}
}

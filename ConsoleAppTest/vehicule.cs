using System;

public class Vehicle : IPilotage
{
    public Vehicle()
    {
    }
    public void moove()
    {
        Console.WriteLine("Le vehicule se deplace");
    }
}
using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class User
{
    public int id { get; set; }
    public string firstname { get; set; }
    public string lastname { get; set; }

    public int old { get; set; }
    public int salary { get; set; }
    public int taxe { get; set; }


    public User(int id, string firstname, string lastname, int old, int salary, int taxe)
    {
        this.id = id;
        this.firstname = firstname;
        this.lastname = lastname;
        this.old = old;
        this.salary = salary;
        this.taxe = taxe;
    }
    public void display()
    {
        //ecrit de maniere esthetique
        Console.WriteLine("Id : " + id + " " + "Nom : " + lastname + " " + "Prénom : " + firstname + " " + "Age : " + old + " " + "Salaire : " + salary + " " + "Taxe : " + taxe);
    }
}

    

using System;
using System.Data.SqlClient;
class Program
{
    static void Main(string[] args)
    {
        string connectionString = "Server=localhost\\MSSQLSERVER01;Database=Animals;Trusted_Connection=True;";
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();

        string query = "SELECT * from espece";
        SqlCommand cmd = new SqlCommand(query, connection);
        SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine(reader["id"].ToString() + " " + reader["name"] + " " + reader["rarity"]);
        }

        Console.WriteLine("Quel est le type de l'animal ?");
        string type = Console.ReadLine();
        Console.WriteLine("Quel est le nom de l'animal ?");
        string name = Console.ReadLine();
        Console.WriteLine("Quel est la rareté de l'animal ?");
        string rarity = Console.ReadLine();
        reader.Close();

        Animal animal = null;
        switch(type.ToLower())
        {
            case "dragon":
                animal = new Dragon(name, rarity);
                break;
            case "griffin":
                animal = new Griffin(name, rarity);
                break;
            case "bird":
                animal = new Bird(name, rarity);
                break;
            case "eagle":
                animal = new Eagle(name, rarity);
                break;
            default:
                Console.WriteLine("Type d'animal inconnu, aucun animal instancié.");
                break;
        }
        if (animal != null)
        {
            animal.display();
            animal.move();
            animal.sleep();
        }

        if (animal is IFly)
        {
            Console.WriteLine("Cet animal peut voler");
        }
        else
        {
            Console.WriteLine("Cet animal ne peut pas voler");
        }

        query = "INSERT INTO espece (name, rarity,type) VALUES ('" + name + "', '" + rarity + "', '" + type + "')";
        SqlCommand cmd2 = new SqlCommand(query, connection);
        int rowsAffected = cmd2.ExecuteNonQuery();
        Console.WriteLine(rowsAffected + " ligne(s) ajoutée(s) à la base de données");
        reader.Close();
        connection.Close();
    }
}
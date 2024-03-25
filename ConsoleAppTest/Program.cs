class Program
{ 
    static void Square(int a , int b)
    { 
        a = a * a;
        b = b * b;
        Console.WriteLine("Carré de a : " + a + " " + "Carré de b : " + b);
    
    }
    static int SalaireBrut(int salaire)
    {
        int mois = 12;
        return (salaire/mois);
    }
    
    static int SalaireNet(int salaireBrut, int taxe)
    {
        double coeff = Convert.ToDouble(taxe)/100;
        double result = (Convert.ToDouble(salaireBrut) * (1- coeff ));
        return (Convert.ToInt32((result)));
    }


    static void Main(string[] args) {
        /*Console.WriteLine("Rentrez un nombre : ");
        string rep1 = Console.ReadLine();
        int num1 = int.Parse(rep1);

        Console.WriteLine("Rentrez un second nombre : ");
        string rep2 = Console.ReadLine();
        int num2 = int.Parse(rep2);

        Square(num1, num2);
        Console.WriteLine("Press enter to Exit...");
        Console.ReadLine();
        // Consigne 1 :
        Console.WriteLine(SalaireBrut(30000));
        int salairebrut = int.Parse(args[0]);
        int taxe = int.Parse(args[1]);

        //Consigne 2 :
        Console.WriteLine(SalaireNet(SalaireBrut(salairebrut), taxe));
        */
        //Consigne 3 :
        Console.WriteLine("Rentrez un salaire brut annuel : ");
        string salaireBrutInputAnnuelStr = Console.ReadLine();
        int salaireBrutAnnuelInput;

        if (!int.TryParse(salaireBrutInputAnnuelStr, out salaireBrutAnnuelInput))
        {
            Console.WriteLine("Le salaire brut doit être un nombre entier.");
            return; // Sortie du programme ou traitement de l'erreur selon vos besoins
        }

        Console.WriteLine("Rentrez un taux d'imposition : ");
        string taxeinputstr = Console.ReadLine();
        int taxeinput;
        if (!int.TryParse(taxeinputstr, out taxeinput))
        {
            Console.WriteLine("Le taux d'imposition doit être un nombre entier.");
            return; // Sortie du programme ou traitement de l'erreur selon vos besoins
        }

        int resultat = SalaireNet(SalaireBrut(salaireBrutAnnuelInput), taxeinput);
        /*
        if (salaireBrutAnnuelInput >= 50000) {
            Console.WriteLine("Fais des dons stp");
        }
        else if (SalaireBrut(salaireBrutAnnuelInput) < 1500)
        {
            Console.WriteLine("Normal pour un alternant !!");
        }
        
        else if (salaireBrutAnnuelInput <= 40000 || 30000 <= salairebrut)
        {
            Console.WriteLine("Viens a CESI");
        }
        else
        {
            Console.WriteLine("Votre Salaire net mensuel est : " + resultat);
        }
        */

        string[] mois = new string[12] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
        
        for(int i = 0; i < mois.Length; i++)
        {
            if (i == 11)
            {
                int prime = salaireBrutAnnuelInput/10;
                int newSalaire = resultat + prime;
                Console.WriteLine("Vous avez reçu une prime votre salaire de décembre est de : " + newSalaire);
            }
            else if (i == 7)
            {
                continue;
            }
            else
            {
                Console.WriteLine("Votre salaire de " + mois[i] + " est : " + resultat);
            }
            
        }
    }
}

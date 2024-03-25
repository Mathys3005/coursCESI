using System.Linq.Expressions;

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

        User user = new User(1, "", "", 0, 0, 0);
        Console.WriteLine("Bonjour, quel est votre nom ?");
        string nom = Console.ReadLine();
        user.lastname = nom;

        Console.WriteLine("Quel est votre prénom ?");
        string prenom = Console.ReadLine();
        user.firstname = prenom;

        Console.WriteLine("Quel est votre âge ?");
        string age = Console.ReadLine();
        int ageint;
        if (!int.TryParse(age, out ageint))
        {
            Console.WriteLine("L'âge doit être un nombre entier.");
            return; // Sortie du programme ou traitement de l'erreur selon vos besoins
        }
        else if (ageint < 0)
        {
            Console.WriteLine("L'âge doit être un nombre positif.");
            return; // Sortie du programme ou traitement de l'erreur selon vos besoins
        }
        else if (ageint < 18)
        {
            Console.WriteLine("Vous êtes mineur.");
            return; // Sortie du programme ou traitement de l'erreur selon vos besoins
        }
        user.old = ageint;


        Console.WriteLine("Bonjour Faites un choix \n 1. Calculer son salaire mensuel net \n 2. Calculer ses intérêts composés.");
        string choix = Console.ReadLine();
        switch (choix)
        {
            case "1":
                Console.WriteLine("Vous avez choisi de calculer votre salaire mensuel net");
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

                user.salary = salaireBrutAnnuelInput;
                user.taxe = taxeinput;

                int resultat = SalaireNet(SalaireBrut(salaireBrutAnnuelInput), taxeinput);
                string[] mois = new string[12] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };

                for (int i = 0; i < mois.Length; i++)
                {
                    if (i == 11)
                    {
                        try {
                            Console.WriteLine("Vous avez eu une prime de combien de pourcent la voulez vous ? (brut annuel)");
                            string percentage = Console.ReadLine();
                            double coeffPrime = 1 - (Convert.ToDouble(percentage) / 100);
                            int prime = Convert.ToInt32(salaireBrutAnnuelInput - (salaireBrutAnnuelInput * coeffPrime));
                            Console.WriteLine(prime);
                            int newSalaire = resultat + prime;
                            int coeffinutilepourexception = 100 / Convert.ToInt32(percentage);
                            Console.WriteLine("Vous avez reçu une prime de " + prime +" , votre salaire de décembre est de : " + newSalaire);
                            user.display();
                            //int prime = salaireBrutAnnuelInput/10;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Merci de mettre un nombre entier");
                            //Console.WriteLine("Erreur : " + e.Message);
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine("Merci de ne pas mettre 0");
                            //Console.WriteLine("Erreur : " + e.Message);
                        }
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
                break;
            case "2":
                Console.WriteLine("Vous avez choisi de calculer vos intérêts composés");
                Console.WriteLine("Rentrez un capital initial : ");
                string montantInitialStr = Console.ReadLine();
                int montantInitial;
                if (!int.TryParse(montantInitialStr, out montantInitial))
                {
                    Console.WriteLine("Le montant initial doit être un nombre entier.");
                    return; // Sortie du programme ou traitement de l'erreur selon vos besoins
                }

                Console.WriteLine("A quel taux d'intérêt ? ");
                string tauxInteretStr = Console.ReadLine();
                int tauxInteret;
                if (!int.TryParse(tauxInteretStr, out tauxInteret))
                {
                    Console.WriteLine("Le taux d'intérêt doit être un nombre entier.");
                    return; // Sortie du programme ou traitement de l'erreur selon vos besoins
                }

                Console.WriteLine("Sur combien d'années ? ");
                string anneesStr = Console.ReadLine();
                int annees;
                if (!int.TryParse(anneesStr, out annees))
                {
                    Console.WriteLine("Le nombre d'années doit être un nombre entier.");
                    return; // Sortie du programme ou traitement de l'erreur selon vos besoins
                }

                for (int i = 0; i < annees; i++)
                {
                    montantInitial = montantInitial + (montantInitial * tauxInteret / 100);
                    Console.WriteLine("Votre capital après " + (i + 1) + " année est de : " + montantInitial);
                }
                
                //User user2 = new User(2, "Jean", "Dupont", 25, 30000, 10);
                //Console.WriteLine("User 2 : " + user2.firstname + " Nom : " + user2.lastname + " Age : " + user2.old + " salary : " + user2.salary + " taxe : " + user2.taxe);
                break;
            default:
                break;
        }
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

    }
}

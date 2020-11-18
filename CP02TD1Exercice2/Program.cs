using System;

namespace CP02TD1Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {// déclaration des variables
            float Releve1, Releve2, DifferenceReleve, Consommation, PrixHT, PrixTTC, PrixSuperieur, TvaConsommation;
            int Location = 5;
            int Tva = 20;

         //enregistrement des relevés
            Console.Write("Entrez le premier relevé : ");
            Releve1 = float.Parse(Console.ReadLine());
            Console.Write("entrez le second relevé : ");
            Releve2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            //difference entre les deux relevés
            Consommation = Releve2 - Releve1;

            //calcule du prix TTC si consommation < 100
            if(Consommation < 100)
            {
                PrixHT = Consommation * 0.10f;
                PrixHT = PrixHT + Location;
                Console.WriteLine("le prix HT est de " + PrixHT + "euro");
                TvaConsommation = PrixHT * Tva / 100;
                PrixTTC = PrixHT + TvaConsommation;
                Console.Write("Le prix TTC est de " + PrixTTC + "euro");

            }

            //calcule du prix ttc si consommation > 100
            else
            {
                Consommation = Consommation - 100;
                PrixHT = Consommation * 0.5f;
                PrixHT = PrixHT + 10;
                Console.WriteLine("le prix HT est de " + PrixHT + "euro");
                TvaConsommation = PrixHT * Tva / 100;
                PrixTTC = PrixHT + TvaConsommation;
                Console.Write("Le prix TTC est de " + PrixTTC + "euro");
            }

        }
    }
}

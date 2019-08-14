using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2_Ex1_Compte;
using TP2_Ex1_Client;

namespace TP2_Ex1
{
    class Program
    {
        static void Main(string[] args) //Methode principale
        {
            Compte Compte1 = new Compte(1);
            Compte Compte2 = new Compte(2);

            Client Client1 = new Client(1, "Romain");

            Compte1.crediter(200);
            Compte1.afficher();
            Compte1.debiter(100);
            Compte1.afficher();
            Console.WriteLine("");
            Compte2.crediter(3000);
            Compte2.afficher();
            Compte2.debiter(1000);
            Compte2.afficher();
            Console.WriteLine("");

            Client1.affecterCompte(Compte1);
            Client1.affecterCompte(Compte2);
            Console.WriteLine("Nombre de Compte du Client : " + Client1.getNbCompte());
            Console.WriteLine("Le Solde total est de : " + Client1.total());
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2_Ex1_Client;

namespace TP2_Ex1_Compte
{
    class Compte
    {
        //ATTRIBUTS
        private int numeroCompte;
        private double solde;

        public Compte(int pnum) //CONSTRUCTEUR
        {
            this.numeroCompte = pnum;
            this.solde = 0;
        }

        //METHODES
        public void crediter(double pmontant)
        {
            this.solde += pmontant;
        }

        public void debiter(double pmontant)
        {
            this.solde -= pmontant;
        }

        public void afficher()
        {
            Console.WriteLine("Numéro de Compte : " + this.numeroCompte);
            Console.WriteLine("Solde : " + this.solde);
            Console.Read();
        }

        public double getSolde()
        {
            return solde;
        }

        public int getNumeroCompte()
        {
            return numeroCompte;
        }
    }
}

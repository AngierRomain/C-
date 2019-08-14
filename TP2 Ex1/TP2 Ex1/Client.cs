using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2_Ex1_Compte;

namespace TP2_Ex1_Client
{
    class Client
    {
        //ATTRIBUTS
        private static int MAX = 10;
        private int numeroClient;
        private String nom;
        private Compte[] lesComptes; //tableau d'objet
        private int nbCompte;


        public Client(int pnum, String pnom) //CONSTRUCTEUR
        {
            this.numeroClient = pnum;
            this.nom = pnom;
            this.lesComptes = new Compte[MAX]; //on instancie le tableau d'objet
            this.nbCompte = 0;
        }

        //METHODES
        public double total()
        {
            double res = 0;

            for (int i = 0; i < nbCompte; i++)
            {
                res += lesComptes[i].getSolde();
            }
            return res;
        }

        public int getNumeroClient()
        {
            return numeroClient;
        }

        public String getNom()
        {
            return nom;
        }

        public void setNom(String nom)
        {
            this.nom = nom;
        }

        public int getNbCompte()
        {
            return nbCompte;
        }

        public void affecterCompte(Compte unCompte)
        {
            if (this.nbCompte != MAX)
            {
                lesComptes[nbCompte] = unCompte;
                nbCompte += 1;
            }
            else
            {
                Console.WriteLine("Erreur : Nombre MAX de Compte atteint");
                Console.ReadKey(true);

            }
        }
    }
}

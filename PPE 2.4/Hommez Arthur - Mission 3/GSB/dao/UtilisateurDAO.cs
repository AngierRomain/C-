using metier;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dao
{
    public class UtilisateurDAO
    {
        public static List<Utilisateur> chargerUtilisateurs()
        {
            List<Utilisateur> uneListeUtilisateurs = new List<Utilisateur>();
            String uneRequete = "SELECT id, nom, prenom, login, mdp, adresse, cp, ville, dateEmbauche, codeType FROM utilisateur";

            MySqlDataReader unDataReader = DbConnexion.GetDataReader(uneRequete);

            while (unDataReader.Read())
            {
                Utilisateur unUtilisateur = new Utilisateur(unDataReader.GetString(0), unDataReader.GetString(1), unDataReader.GetString(2), unDataReader.GetString(3), unDataReader.GetString(4), unDataReader.GetString(5), unDataReader.GetString(6), unDataReader.GetString(7), unDataReader.GetDateTime(8),unDataReader.GetString(9));
                uneListeUtilisateurs.Add(unUtilisateur);
            }
            unDataReader.Close();
            return uneListeUtilisateurs;
        }


        public static String[] authentificationUtilisateur(String unLogin, String unMdP)
        {
            String uneRequete = "SELECT * FROM utilisateur where login = '" + unLogin + "' AND mdp = '" + unMdP + "'";

            MySqlDataReader unDataReader = DbConnexion.GetDataReader(uneRequete);

            String[] tabAuthen = new String[10];
            if (unDataReader.HasRows)
            {
                unDataReader.Read();
                tabAuthen[0] = unDataReader.GetString(0);
                tabAuthen[1] = unDataReader.GetString(1);
                tabAuthen[2] = unDataReader.GetString(2);
                tabAuthen[3] = unDataReader.GetString(3);
                tabAuthen[4] = unDataReader.GetString(4);
                tabAuthen[5] = unDataReader.GetString(5);
                tabAuthen[6] = unDataReader.GetString(6);
                tabAuthen[7] = unDataReader.GetString(7);
                tabAuthen[8] = unDataReader.GetString(8);
                tabAuthen[9] = unDataReader.GetString(9);
            }
            unDataReader.Close();

            return tabAuthen;
        }


    }
}

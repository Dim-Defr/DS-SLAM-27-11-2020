using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Business
{
   public class Joueur
    {
        private int id;
        private string nom;
        private DateTime dateEntree;
        private DateTime dateNaissance;
        private Pays pays;
        private Poste poste;


        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public DateTime DateEntree { get => dateEntree; set => dateEntree = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        internal Pays Pays { get => pays; set => pays = value; }
        internal Poste Poste { get => poste; set => poste = value; }
    

        public Joueur(int UnID,String UnNom,DateTime UneDateEntree,DateTime UneDateNaissance,Pays UnPays,Poste UnPoste)
        {
            id = UnID;
            nom = UnNom;
            dateEntree = UneDateEntree;
            dateNaissance = UneDateNaissance;
            pays = UnPays;
            poste = UnPoste;
        }

        public Joueur()
        {
            id = 0;
            nom = "";
            dateEntree = new DateTime();
            dateNaissance = new DateTime();
            pays = new Pays();
            poste = new Poste();
        }
    }
}

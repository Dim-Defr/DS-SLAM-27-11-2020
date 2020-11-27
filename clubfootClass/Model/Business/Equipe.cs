using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Business
{
    public class Equipe
    {   
        private int id;
        private string nom;
        private DateTime dateCreation;
        private List<Joueur> Joueurs;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public DateTime DateCreation { get => dateCreation; set => dateCreation = value; }
        
        

        public Equipe()
        {
            id = 0;
            nom = "";
            dateCreation = new DateTime();

        }

        public Equipe(int unId, string UnNom, DateTime UneDatedeCreation)
        {
            id = unId;
            nom = UnNom;
            dateCreation = UneDatedeCreation;
            List<Joueur> Joueur = new List<Joueur>();
        }
        public override string ToString()
        {
            return this.nom.ToString();
        }

    }
}

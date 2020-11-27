using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Business
{
    class Joueur
    {
        private int id;
        private string nom;
        private DateTime dateEntree;
        private DateTime dateNaissance;
        
        

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public DateTime DateEntree { get => dateEntree; set => dateEntree = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        


    }
}

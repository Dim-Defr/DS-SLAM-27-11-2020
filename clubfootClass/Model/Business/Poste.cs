using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Business
{
    class Poste
    {
        private int id;
        private string nom;
        private int escouade;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public int Escouade { get => escouade; set => escouade = value; }

        public Poste()
        {
            id = 0;
            nom = "";
            escouade = 0;
        }

        public Poste(int unId,string unNom,int UneEscouade)
        {
            id = 0;
            nom = "";
            escouade = 0;
        }
    }
}

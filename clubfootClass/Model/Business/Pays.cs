using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Business
{
    class Pays
    {
        private int id;
        private string nom;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }

        public Pays()
        {
            id = 0;
            nom = "";
        }

        public Pays(int UnID,string unNom)
        {
            id = UnID;
            nom = unNom;
        }
    }
}

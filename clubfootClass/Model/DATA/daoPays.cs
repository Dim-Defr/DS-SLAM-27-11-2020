using System;
using System.Collections.Generic;
using System.Data;
using Model.Business;
namespace Model.DATA
{
    class daoPays
    {

        private DBAL _mydbal;


        public daoPays(DBAL BDD)
        {

            _mydbal = BDD;
        }

        public void Insert(Pays Unpays) //insérer une ligne

        {
            Console.WriteLine("INSERT INTO pays (id,nom) values (" + Unpays.Id + ", '" + Unpays.Nom + "');");
            _mydbal.Insert("INSERT INTO pays (id,nom) values (" + Unpays.Id + ", '" + Unpays.Nom.Replace("'", "''") + "');");

        }

        public void Update(Pays Unpays)// mettre à jour une ligne
        {
            _mydbal.Update("UPDATE pays set id = " + Unpays.Id + ", nom = '" + Unpays.Nom + "' where  id = " + Unpays.Id + " ;"); ;

        }

        public void Delete(Pays Unpays) //supprimer une ligne
        {
            _mydbal.Delete("DELETE FROM pays where id = " + Unpays.Id + " ;");

        }
        //CSVHelper
        
        public List<Pays> SelectAll()
        {
            List<Pays> lePays = new List<Pays>();
            foreach (DataRow DataR in _mydbal.SelectALL("pays").Rows)
            {
                Console.WriteLine(DataR["id"] + " " + DataR["nom"]);
                lePays.Add(new Pays((int)DataR["id"], (string)DataR["nom"]));
                Console.WriteLine("ajouter");
            }
            return lePays;
        }

        public Pays selectByName(string UnPays)
        {
            DataRow dr = _mydbal.SelectByField("pays", "nom like '" + UnPays + "'").Rows[0];
            return new Pays((int)dr["id"], (string)dr["nom"]);
        }

        public Pays selectByID(int IDPays)
        {
            DataRow dr = _mydbal.SelectByID("pays", IDPays);
            return new Pays((int)dr["id"], (string)dr["nom"]);
        }
    }
}

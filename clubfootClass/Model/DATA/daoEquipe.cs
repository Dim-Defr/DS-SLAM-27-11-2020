
using System;
using System.Collections.Generic;
using System.Data;
using Model.Business;
namespace Model.DATA
{
    public class daoEquipe
    {
        private DBAL _mydbal;
        private daoJoueur _myDaoJoueur;
        

        public daoEquipe(DBAL UnDBAL)
        {
            _mydbal = UnDBAL;
            



        }
        public  List<Equipe> SelectAll()
        {
            List<Equipe> lesEquipes = new List<Equipe>();
            foreach (DataRow DataR in _mydbal.SelectALL("equipe").Rows)
            {
                lesEquipes.Add(new Equipe(
                    (int)DataR["id"],
                    (string)DataR["nom"],
                    (DateTime)DataR["dateCreation"]
                    
                    

                    ));
            }
            return lesEquipes;
        }
    }
}

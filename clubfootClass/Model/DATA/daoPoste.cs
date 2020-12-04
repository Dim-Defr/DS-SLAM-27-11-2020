using System;
using System.Collections.Generic;
using System.Data;
using Model.Business;

namespace Model.DATA
{
    public class daoPoste
    {
        private DBAL _mydbal;

        public daoPoste(DBAL UnDBAL)
        {
            _mydbal = UnDBAL;
        }
        public List<Poste> SelectAll()
        {
            List<Poste> lesPostes = new List<Poste>();
            foreach (DataRow DataR in _mydbal.SelectALL("poste").Rows)
            {
                lesPostes.Add(new Poste(
                    (int)DataR["id"],
                    (string)DataR["nom"],
                    (int)DataR["escouade"]
                    ));
            }
            return lesPostes;
        }
        public Poste selectByID(int IDPays)
        {
            DataRow dr = _mydbal.SelectByID("poste", IDPays);
            return new Poste(
                (int)dr["id"],
                (string)dr["nom"],
                (int)dr["escouade"]
                );
        }
    }
}

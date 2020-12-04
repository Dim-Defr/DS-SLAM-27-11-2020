using System;
using System.Collections.Generic;
using System.Data;
using Model.Business;
namespace Model.DATA
{
   public class daoJoueur
    {
        private DBAL _mydbal;
        private daoPays _myDaoPays;
        private daoPoste _myDaoPoste;

        public daoJoueur(DBAL UnDbal,daoPays UneDaoPays,daoPoste UneDaoPoste)
        {
            _mydbal = UnDbal;
            _myDaoPays = UneDaoPays;
            _myDaoPoste = UneDaoPoste;

        }
        public List<Joueur> SelectByEquipe(Equipe UneEquipe)
        {
            List<Joueur> lesJoueurs = new List<Joueur>();
            foreach (DataRow DataR in _mydbal.SelectByField("joueur","equipe = "+UneEquipe.Id).Rows)
            {
                lesJoueurs.Add(new Joueur(
                    (int)DataR["id"],
                    (string)DataR["nom"],
                    (DateTime)DataR["dateEntree"],
                    (DateTime)DataR["dateNaissance"],
                    _myDaoPays.selectByID((int)DataR["pays"]),
                    _myDaoPoste.selectByID((int)DataR["pays"])

                    ));
            }
            return lesJoueurs;
        }
        public List<Joueur> SelectAll()
        {
            List<Joueur> lesJoueurs = new List<Joueur>();
            foreach (DataRow DataR in _mydbal.SelectALL("joueur").Rows)
            {
                lesJoueurs.Add(new Joueur(
                    (int)DataR["id"],
                    (string)DataR["nom"],
                    (DateTime)DataR["dateEntree"],
                    (DateTime)DataR["dateNaissance"],
                    _myDaoPays.selectByID((int)DataR["pays"]),
                    _myDaoPoste.selectByID((int)DataR["pays"])

                    ));
            }
            return lesJoueurs;
        }

    }
}

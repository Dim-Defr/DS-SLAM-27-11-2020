using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Model.Business;
using Model.DATA;


namespace ClubfootApp.viewModel
{
    class viewModelJoueur : viewModelBase
    {
        private daoEquipe vmDaoEquipe;
        //rajouter les autres dao
        private ICommand updateCommand;
        private ObservableCollection<Equipe> listEquipe;

        public ObservableCollection<Equipe> ListEquipes { get => listEquipe; set => listEquipe = value; }
        
   public viewModelJoueur(daoEquipe thedaoEquipe)
           {
               vmDaoEquipe = thedaoEquipe;

       

               listEquipe = new ObservableCollection<Equipe>(thedaoEquipe.SelectAll());
 /*

               foreach (Fromage f in listFromage)
               {
                   //pas optimal 2 foreach, remplacer le 2 eme foreach par un for
                   foreach (Pays p in listPays)
                   {
                       if (f.Origine.Nom == p.Nom)
                       {
                           f.Origine = p;
                       }
                   }
               }*/

           }
    }
}

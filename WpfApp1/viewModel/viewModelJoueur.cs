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
        private daoJoueur vmDaoJoueur;
        private daoPays vmDaoPays;
        private daoPoste vmDaoPoste;

        //rajouter les autres dao
        private ICommand updateCommand;
        private ICommand insertCommand;
        private ICommand deleteCommand;
        private ObservableCollection<Equipe> listEquipe;
        private ObservableCollection<Joueur> listJoueur;
        private ObservableCollection<Pays> listPays;
        private ObservableCollection<Poste> listPoste;
        private Equipe selectedEquipe = new Equipe();
        private Joueur selectedJoueur = new Joueur();


        public ObservableCollection<Equipe> ListEquipes { get => listEquipe; set => listEquipe = value; }
        public ObservableCollection<Joueur> ListJoueurs { get => listJoueur; set => listJoueur = value; }
        public ObservableCollection<Pays> ListPays { get => listPays; set => listPays = value; }
        public ObservableCollection<Poste> ListPostes { get => listPoste; set => listPoste = value; }

        

        public Equipe SelectedEquipe
        {

            
            get => selectedEquipe;
            set
            {
                if (selectedEquipe != value)
                {
                    selectedEquipe = value;
                    //création d'un évènement si la propriété Name (bindée dans le XAML) change
                    ListJoueurs = new ObservableCollection<Joueur>(vmDaoJoueur.SelectByEquipe(selectedEquipe));
                    OnPropertyChanged("ListJoueurs");
                    
                }
            }
        }

        public Joueur SelectedJoueur
        {
            get => selectedJoueur;
            set
            {
                if (selectedJoueur != value)
                {
                    selectedJoueur = value;
                    //création d'un évènement si la propriété Name (bindée dans le XAML) change
                    OnPropertyChanged("Name");
                    OnPropertyChanged("Naiss");
                    OnPropertyChanged("Entree");
                    OnPropertyChanged("Origin");
                    OnPropertyChanged("Poste");

                }
            }
        }

        public string Name
        {

            get => selectedJoueur.Nom;
            set
            {
                if (SelectedJoueur.Nom != value)
                {
                    SelectedJoueur.Nom = value;
                    //création d'un évènement si la propriété Name (bindée dans le XAML) change
                    OnPropertyChanged("Name");
                }
            }
        }

        

        public viewModelJoueur(daoEquipe thedaoEquipe,daoJoueur thedaoJoueur,daoPays thedaoPays,daoPoste thedaoPoste)
           {
               vmDaoEquipe = thedaoEquipe;
               vmDaoJoueur = thedaoJoueur;
               vmDaoPays = thedaoPays;
               vmDaoPoste = thedaoPoste;



            listEquipe = new ObservableCollection<Equipe>(thedaoEquipe.SelectAll());
            listJoueur = new ObservableCollection<Joueur>(thedaoJoueur.SelectAll());
            listPays = new ObservableCollection<Pays>(thedaoPays.SelectAll());
            listPoste = new ObservableCollection<Poste>(thedaoPoste.SelectAll());


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

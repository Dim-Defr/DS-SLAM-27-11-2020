using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Model.DATA;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private DBAL thedbal;
        private daoEquipe thedaoequipe;
        private daoJoueur thedaojoueur;
        private daoPays thedaopays;
        private daoPoste thedaoposte;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //C'est ici, dans la méthode Application_Startup, qu'on instancie nos objets Dbal et Dao
            thedbal = new DBAL("dsfootamericain");
           
            thedaopays = new daoPays(thedbal);
            thedaoposte = new daoPoste(thedbal);
            thedaojoueur = new daoJoueur(thedbal,thedaopays,thedaoposte);
            thedaoequipe = new daoEquipe(thedbal);

            // Create the startup window

            //là, on lance la fenêtre souhaitée en instanciant la classe de notre fenêtre
            MainWindow wnd = new MainWindow(thedaoequipe,thedaojoueur,thedaopays,thedaoposte);
            //et on utilise la méthode Show() de notre objet fenêtre pour afficher la fenêtre
            //exemple: MainWindow lafenetre = new MainWindow(); (et on y passe en paramètre Dbal et Dao au besoin)
            wnd.Show();


        }
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("An unhandled exception just occurred: " + e.Exception.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            e.Handled = true;
        }
    }
}

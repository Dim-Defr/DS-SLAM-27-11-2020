using System;
using Model.Business;
using Model.DATA;

namespace clubfootConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DBAL MaBDD = new DBAL();//nouvel instance DBAL
            Console.WriteLine("Bonjour !");
            daoEquipe daoE = new daoEquipe(MaBDD);

            daoE.SelectAll();
            foreach (Equipe item in daoE.SelectAll())
            {
                Console.WriteLine(item.Id+ " " + item.Nom);
            }
        }
    }
}

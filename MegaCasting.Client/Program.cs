using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCasting.DBLib;

namespace MegaCasting.Client
{
    class Program
    {

        #region Static Attributes

        public static MegaCastingEntities MegaCastingEntities = new MegaCastingEntities();

        #endregion

        #region Static Methods
        /// <summary>
        /// Classe du programme principal
        /// </summary>
        /// <param name="args">argument passés en paramètres</param>

        static void Main(string[] args)
        {
            string userChoice = "0";
            do
            {
                Console.WriteLine(
               "---Megacasting---" + Environment.NewLine
            + "1 - Ajout d'un producteur" + Environment.NewLine
            + "2 - Modification d'un producteur" + Environment.NewLine
            + "3 - Lister les producteurs" + Environment.NewLine
            + "0 - Quitter"


               );
                userChoice = Console.ReadLine();
                if (userChoice != "0")
                {
                    switch (userChoice)
                    {
                        case "1":
                            AddProducer();
                            break;
                        case "2":
                            UpdateProducer();
                            //TODO : Mise à jour. Pouvoir changer le nom, "le mot de passe". 
                            break;
                        case "3":
                            ShowProducteur();
                            choixAction();
                            break;
                        default:
                            break;
                    }
                }

            }
            while (userChoice != "0");
          
        }

        /// <summary>
        /// Ajoute en base de données un nouveau producteur
        /// </summary>
        public static void AddProducer()
        {
            Producer producer = new Producer();
            Console.WriteLine("Le nom du producteur :");
            producer.Name = Console.ReadLine();

            Console.WriteLine("Un mot de passe aléatoire va être affecté");
            producer.Password = GeneredPassword(); 

            // On ajoute le producteur à la liste
            MegaCastingEntities.Producers.Add(producer);


            // On push les modifications en base de données
            MegaCastingEntities.SaveChanges();
        }
        public static void UpdateProducer()
        {

            ShowProducteur();

            Console.WriteLine("Entrez l'indentifiant du producteur que vous souhaitez modifier :");
            string toDeleteString = Console.ReadLine();

            int isInteger = 0;

            if (int.TryParse(toDeleteString, out isInteger))
            {
                //On vérifie que le prodcteur existe
                if (MegaCastingEntities
                        .Producers
                        .Any(producer => producer.Identifier == isInteger))
                {
                    //Si il existe on le récupère
                    Producer producer = MegaCastingEntities
                    .Producers
                    .First(producerTemp => producerTemp.Identifier == isInteger);

                    //On demande quel nouveau nom enregistrer
                    Console.WriteLine("Entrez le nouveau nom : ");
                    producer.Name = Console.ReadLine();


                    //On valide les changements
                    MegaCastingEntities.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Le producteur n°" + isInteger + " n'existe pas !");
                }
            }
        }

        public static void ShowProducteur()
        {
            //Récupération de la liste des producteurs
            List<Producer> producers = MegaCastingEntities
                .Producers
                .ToList();

            //Affichage
            producers.ForEach(producer => Console.WriteLine(
                "Id :" + producer.Identifier + " - " + producer.Name
                )
            );
        }

        public static void choixAction()
        {
            Console.WriteLine("1 - Supprimer");
            Console.WriteLine("0 - Quitter");
            int choix = 0;
            while (!int.TryParse(Console.ReadLine(), out choix) || choix < 0 || choix > 2)
            {
                Console.WriteLine("Nombre incorrect, veuillez réessayer");
            }
            switch (choix)
            {
                case 1:
                    removeProducer();
                    break;
                default:
                    break;
            }
        }
        public static void removeProducer()
        {
            //Demande de suppession évntuelle ? 
            Console.WriteLine("Ecrivez son identifiant :");
            string toDeleteString = Console.ReadLine();

            int isInteger = 0;

            if (int.TryParse(toDeleteString, out isInteger))
            {
                //On vérifie que le prodcteur existe
                if (MegaCastingEntities
                        .Producers
                        .Any(producer => producer.Identifier == isInteger))
                {
                    //Si il existe on le récupère
                    Producer producer = MegaCastingEntities
                    .Producers
                    .First(producerTemp => producerTemp.Identifier == isInteger);

                    //On le supprime
                    MegaCastingEntities.Producers.Remove(producer);


                    //On valide les changements
                    MegaCastingEntities.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Le producteur n°" + isInteger + " n'existe pas !");
                }
            }
            
        }
        public static string GeneredPassword()
        {
            string caracteres = "azertyuiopqsdfghjklmwxcvbn"; // ca tu devine
            Random selAlea = new Random(); // mon objet aléatoire


            string password = ""; // le mot de passe a la fin
            for (int i = 0; i < 8; i++) // 8 caracteres, la taille du mot de passes
            {
                // a chaque tour de boucle marOrMin va valoir sois 0 ou 1 c'est aléatoire
                int majOrMin = selAlea.Next(2); // un nombre aléatoire qui vaut 0 ou 1

                // un caractere au hazard dans la chaine (caractere transformé en string)
                string carac = caracteres[selAlea.Next(0, caracteres.Length)].ToString();

                // si le nombre vaut 0
                if (majOrMin == 0)
                {
                    password += carac.ToUpper(); // on met le caracteres en majuscule
                                            //et on le met dans lachaine
                }
                else
                {
                    password += carac.ToLower(); //on met le caracteres en minscule et on le met dans lachaine
                }
            }
            return password;

        }


        #endregion
    }
}

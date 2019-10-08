using MegaCasting.WPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MegaCasting.WPF.Windows;
using MegaCasting.WPF.Views;


namespace MegaCasting.WPF.Windows
{
    /// <summary>
    /// Logique d'interaction pour WindowsAddAnnouncer.xaml
    /// </summary>
    public partial class WindowAddAnnouncer : Window
    {
        private ViewModelViewAnnouncer _ViewModelViewAnnouncer;


        public WindowAddAnnouncer()
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        public WindowAddAnnouncer(ViewModelViewAnnouncer viewAnnouncer)
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            _ViewModelViewAnnouncer = viewAnnouncer;
        }

        #region Events

        /// <summary>
        /// Ferme la fenêtre actuelle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Réduit la fenêtre actuelle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        /// <summary>
        /// Maximise la fenêtre actuelle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }

        }
        /// <summary>
        /// Permet de déplacer la fenêtre princpale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainBar_MouseDown(object sender, RoutedEventArgs e)
        {
            this.DragMove();
        }


        /// <summary>
        /// Demande confirmation et ajoute un annonceur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddAnnouncer_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = 
                MessageBox.Show(
                    "Souhaitez-vous confirmer l'ajout",
                    "Ajout d'un annonceur",
                    MessageBoxButton.YesNo);
            if(result == MessageBoxResult.Yes)
            {
                string password = GeneredPassword();
                _ViewModelViewAnnouncer.addAnnouncer(textBoxAddNom.Text, textBoxId.Text, password);
                this.Close();
            }
            
        }
        #endregion

        #region Methods


        /// <summary>
        /// Génère un mot de passe aléatoire de 8 caractère
        /// </summary>
        /// <returns></returns>
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

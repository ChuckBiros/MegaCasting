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
                _ViewModelViewAnnouncer.addAnnouncer(textBoxAddNom.Text, textBoxId.Text);
                this.Close();
            }
            
        }
        #endregion
    }
}

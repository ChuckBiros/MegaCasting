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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MegaCasting.WPF.Views;

namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Events
        /// <summary>
        /// Eteint la fenêtre principale
        /// </summary>
        /// <param name="sender">origine</param>
        /// <param name="e">arguments</param>
        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Affiche le panel des annonceurs
        /// </summary>
        /// <param name="sender">origine</param>
        /// <param name="e">arguments</param>
        private void ButtonAnnouncer_Click(object sender, RoutedEventArgs e)
        {
            CleanPanel();
            ViewAnnouncers viewAnnouncers = new ViewAnnouncers();
            this.dockPanelMain.Children.Add(viewAnnouncers);

        }

        /// <summary>
        /// Affiche le panel des types de contrats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonContactType_Click(object sender, RoutedEventArgs e)
        {
            CleanPanel();
            ViewContractType viewContractTypes = new ViewContractType();
            this.dockPanelMain.Children.Add(viewContractTypes);
        }

        /// <summary>
        /// Affiche le panel des annonces
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOffers_Click(object sender, RoutedEventArgs e)
        {
            CleanPanel();
            ViewOffers viewOffers = new ViewOffers();
            this.dockPanelMain.Children.Add(viewOffers);
        }
        #endregion


        #region Methods

        /// <summary>
        /// Permet la suppression du panel affiché
        /// </summary>
        private void CleanPanel()
        {
            this.dockPanelMain.Children.Clear();
        }

        #endregion

    }
}

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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MegaCasting.WPF.Windows;


namespace MegaCasting.WPF.Views
{
    /// <summary>
    /// Logique d'interaction pour ViewAnnouncers.xaml
    /// </summary>
    public partial class ViewAnnouncers : UserControl
    {
        public ViewAnnouncers()
        {
            InitializeComponent();
            this.DataContext = new ViewModelViewAnnouncer();
        }


        #region Events



        /// <summary>
        /// Action d'ajout d'un annonceur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddAnnouncer_Click(object sender, RoutedEventArgs e)
        {
            WindowAddAnnouncer windowAddAnnouncer = new WindowAddAnnouncer(((ViewModelViewAnnouncer)this.DataContext));
            windowAddAnnouncer.Show();
        }

        #endregion
    }
}

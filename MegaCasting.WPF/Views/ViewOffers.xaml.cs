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
    /// Logique d'interaction pour ViewOffers.xaml
    /// </summary>
    public partial class ViewOffers : UserControl
    {
        public ViewOffers()
        {
            InitializeComponent();
        }

        #region Events
        private void ButtonDescription_Click(object sender, RoutedEventArgs e)
        {
            WindowDescriptionOffers windowDescriptionOffers = new WindowDescriptionOffers();
            windowDescriptionOffers.Show();
        }


        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCasting.DBLib;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelViewAnnouncer : ViewModelBase
    {
        #region Attributes

        /// <summary>
        /// Liste observable des Annonceurs
        /// </summary>
        private ObservableCollection<Producer> _Producers;


        /// <summary>
        /// Annonceur selectionné
        /// </summary>
        private Producer _SelectedProducer;

   

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou défini les annonceurs
        /// </summary>

        public ObservableCollection<Producer> Producers
        {
            get { return _Producers; }
            set { _Producers = value; }
        }

        /// <summary>
        /// Obtient ou définit l'annonceur selectionné
        /// </summary>
        public Producer SelectedProducer
        {
            get { return _SelectedProducer; }
            set { _SelectedProducer = value; }
        }

        #endregion

        #region Constructors
        /// <summary>
        /// Contructeur par défault d'un ViewModelViewAnnouncer
        /// </summary>
        public ViewModelViewAnnouncer()
        {
            Producers = new ObservableCollection<Producer>(this.Entities.Producers);
        }
        #endregion


        #region Methods


        /// <summary>
        /// Ajoute un annonceur
        /// </summary>
        public void addAnnouncer(string name, string pseudo, string password)
        {
            Producer producer = new Producer();
            producer.Name = name;
            producer.UserName = pseudo;
            producer.Password = password;

            this.Entities.Producers.Add(producer);
            this.Producers.Add(producer);
            this.Entities.SaveChanges();
        }

        #endregion
    }
}

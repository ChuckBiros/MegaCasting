using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCasting.DBLib;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelBase
    {
        #region Attributes

        /// <summary>
        /// Entités utilisées en tant que contexte
        /// </summary>
        private MegaCastingEntities _Entities;

        #endregion


        #region Properties

        /// <summary>
        /// Obtient ou défini le contexte
        /// </summary>

        public MegaCastingEntities Entities
        {
            get { return _Entities; }
            set { _Entities = value; }
        }

        #endregion

        #region Constructors
        /// <summary>
        /// COntructeur par défault d'un ViewModelBase
        /// </summary>
        public ViewModelBase()
        {
            this.Entities = new MegaCastingEntities();
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklad_sport_invent.Context.Contacts
{
    /// <summary>
    /// поставщик 
    /// </summary>
    internal class Supplier : BaseAuditEntity
    {
        /// <summary>
        /// название поставщика 
        /// </summary>
        public string NameP   { get; set; }

        /// <summary>
        /// адрес поставщика 
        /// </summary>
        public string AddressP { get; set; }

        /// <summary>
        /// номер телефона поставщика 
        /// </summary>
        public string TelNumP { get; set; }

        /// <summary>
        /// инн поставщика 
        /// </summary>
        public string INN { get; set; }
        /// <summary>
        /// доверенное лицо
        /// </summary>
        public string DoverenoeL { get; set; }
    }
}

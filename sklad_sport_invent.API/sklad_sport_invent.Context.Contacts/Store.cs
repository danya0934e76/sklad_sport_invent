using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklad_sport_invent.Context.Contacts
{
    /// <summary>
    /// склад 
    /// </summary>
    public class Store : BaseAuditEntity
       
    {
        /// <summary>
        /// название склада 
        /// </summary>
        public  string NameS { get; set; }
        /// <summary>
        /// адресс склада 
        /// </summary>
        public string AddressSkl { get; set; }
        /// <summary>
        /// контактное лицо 
        /// </summary>
        public string ContactFace { get; set; }
    }
}

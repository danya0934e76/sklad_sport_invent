using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklad_sport_invent.Context.Contacts
{
    /// <summary>
    /// покупатель 
    /// </summary>
    public class Customer : BaseAuditEntity
    {
        /// <summary>
        /// Фамилия имя отчество 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// адрес
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// номер телефона клиента  
        /// </summary>
        public string TelNum { get; set; }

        /// <summary>
        /// почта 
        /// </summary>
        public  string Email { get; set; }
    }
}

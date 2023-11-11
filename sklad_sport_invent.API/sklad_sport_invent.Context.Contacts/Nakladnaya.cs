using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklad_sport_invent.Context.Contacts
{
    /// <summary>
    /// накладная 
    /// </summary>
    public class Nakladnaya : BaseAuditEntity
    {
        /// <summary>
        /// идентификатор покупателя 
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// идентификатор поставщика 
        /// </summary>
        public Guid SupplierId { get; set; }
        /// <summary>
        /// список продуктов 
        /// </summary>
         public List <VedomProductItrem> Itrems { get; set; }
    }
}

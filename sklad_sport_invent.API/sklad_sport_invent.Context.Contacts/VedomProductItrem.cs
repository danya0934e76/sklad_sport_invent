using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklad_sport_invent.Context.Contacts
{
    /// <summary>
    /// ведомость товара
    /// </summary>
    public class VedomProductItrem 
    {
        /// <summary>
        /// идентификтаор 
        /// </summary>
       public Guid ID { get; set; }
        /// <summary>
        /// идентификтатор товара 
        /// </summary>
        public Guid ProductId { get; set; }
        /// <summary>
        /// количество  товара 
        /// </summary>
        public int Quantity  { get; set; }

        /// <summary>
        /// сумма
        /// </summary>
        public decimal Summ { get; set; }
    }
}

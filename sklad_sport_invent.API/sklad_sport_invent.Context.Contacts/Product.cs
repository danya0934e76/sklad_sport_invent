using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklad_sport_invent.Context.Contacts
{
    /// <summary>
    /// товар 
    /// </summary>
    internal class Product : BaseAuditEntity 
    {
        /// <summary>
        /// название товара 
        /// </summary>
        public string  NameProduct { get; set; }
        /// <summary>
        /// в чем измеряется 
        /// </summary>
        public string MeraIzmer  { get; set; }

        /// <summary>
        /// цена за шткуку
        /// </summary>
        public decimal valueUnit { get; set; }

    }
}

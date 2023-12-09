

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace sklad_sport_invent.Context.Contacts
{
    public interface  IContext
    {
        /// <summary>
        /// покупатели
        /// </summary>
        DbSet<Customer> Customers { get; }
        /// <summary>
        /// накладная
        /// </summary>
        DbSet<Nakladnaya> Nakladnaya { get;}
        /// <summary>
        /// продукт
        /// </summary>
        DbSet<Product> Products { get; }
        /// <summary>
        /// склад
        /// </summary>
        DbSet<Store> Stores { get; }
        /// <summary>
        /// поставщик
        /// </summary>
        DbSet<Supplier> Suppliers { get; }

    }
}

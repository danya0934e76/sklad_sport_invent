

namespace sklad_sport_invent.Context.Contacts
{
    public interface  IContext
    {
        /// <summary>
        /// покупатели
        /// </summary>
        ICollection<Customer> Customers { get; }
        /// <summary>
        /// накладная
        /// </summary>
        ICollection<Nakladnaya> Nakladnaya { get;}
        /// <summary>
        /// продукт
        /// </summary>
        ICollection<Product> Products { get; }
        /// <summary>
        /// склад
        /// </summary>
        ICollection<Store> Stores { get; }
        /// <summary>
        /// поставщик
        /// </summary>
        ICollection<Supplier> Suppliers { get; }

    }
}

using sklad_sport_invent.Context.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklad_sport_invent.Context
{
    public class sklad_sport_inventContext : IContext 
    {
        private ICollection<Customer> customers;
        private ICollection<Nakladnaya> nakladnaya;
        private ICollection<Product> product;
        private ICollection<Store> store;
        private ICollection<Supplier> suppliers;


        public sklad_sport_inventContext()
        {
            customers = new HashSet<Customer>();
            nakladnaya = new HashSet<Nakladnaya>();
            product = new HashSet<Product>();
            store = new HashSet<Store>();
            suppliers = new HashSet<Supplier>();
        }

        public ICollection<Customer> Customers => customers;

        public ICollection<Nakladnaya> Nakladnaya => nakladnaya;

        public ICollection<Product> Products => product;

        public ICollection<Store> Stores => store;

        public ICollection<Supplier> Suppliers => suppliers;
    }
}

using sklad_sport_invent.Context.Contacts;

namespace sklad_sport_invent.Context
{
    public class SkladContext : IContext 
    {
        private ICollection<Customer> customers;
        private ICollection<Nakladnaya> nakladnaya;
        private ICollection<Product> product;
        private ICollection<Store> store;
        private ICollection<Supplier> suppliers;


        public SkladContext()
        {
            customers = new HashSet<Customer>();
            nakladnaya = new HashSet<Nakladnaya>();
            product = new HashSet<Product>();
            store = new HashSet<Store>();
            suppliers = new HashSet<Supplier>();
            Seed();
        }

        public ICollection<Customer> Customers => customers;

        public ICollection<Nakladnaya> Nakladnaya => nakladnaya;

        public ICollection<Product> Products => product;

        public ICollection<Store> Stores => store;

        public ICollection<Supplier> Suppliers => suppliers;

        private void Seed()
        {
            Customers.Add(new Customer
            {
                Id = Guid.NewGuid(),
                Email = "gens@mail.ru",
                Name= "Даня",
                Address = "улица Пушкина 2",
                TelNum = "89237347323" 
            });
            Customers.Add(new Customer
            {
                Id = Guid.NewGuid(),
                Email = "oefs@mail.ru",
                Name = "Ваня",
                Address = "улица Пушкина 3",
                TelNum = "89237347623"
            });
            Products.Add(new Product
            {
                Id = Guid.NewGuid(),
                NameProduct = "Мяч",
                CreatedBy = "Адидас",
            });
            Products.Add(new Product
            {
                Id = Guid.NewGuid(),
                NameProduct = "Бутсы",
                CreatedBy = "Пума",
            });
            Stores.Add(new Store
            {
                Id = Guid.NewGuid(),
                NameS = "Adidas",
                AddressSkl = "Улицца Вязова 3",
                ContactFace = "Зубенко Петр ",
            });
            Stores.Add(new Store
            {
                Id = Guid.NewGuid(),
                NameS = "Puma",
                AddressSkl = "Улицца Вязова 2",
                ContactFace = "Зубенко Михаил ",
               
            });
            Suppliers.Add(new Supplier
            {
                Id = Guid.NewGuid(),
                NameP = "Печкин Вова",
                AddressP = "Красогвардейская улица дом 4",
                INN = "92121345321",
                TelNumP = "89125435465"
            });
            Suppliers.Add(new Supplier
            {
                Id = Guid.NewGuid(),
                NameP = $"NameP{Guid.NewGuid().ToString("N")}",
                AddressP = "Красогвардейская улица дом 5",
                INN = "92121343421",
                TelNumP = "89125426765",

            });
            Nakladnaya.Add(new Nakladnaya
            {
              CustomerId= Guid.NewGuid(),
              SupplierId= Guid.NewGuid(),
             
            });
        }
    }
}

# skladSportInventar

```mermaid
erDiagram
  
    Store ||--o{ Nakladnaya : is
    Store {
        string NameS
        string AddressSkl
        string ContactFace
          }
    CUSTOMER ||--o{ Nakladnaya : places
    CUSTOMER {
        string name
        string custNumber
        string Address
    }
  
    Nakladnaya {
        int CustomerId
        string SupplierId
    }
  Product ||--o{ Store: is
    Product {
        string NameProduct
        string MeraIzmer
        decimal valueUnit
 
    }
 Supplier ||--o{ Store: is
  Supplier {
    string NameP
    string AddressP
    string TelNumP
    string INN   
    string DoverenoeL
   }
```

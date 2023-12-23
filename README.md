**Выполнил: Генча Даниил Андреевич**
=============
Группа: ИП20-7К
--------------------
Тема: Склад спортивного инвентаря 
-----------------
![image](https://github.com/danya0934e76/sklad_sport_invent/assets/107752444/ddc0cfdf-fdce-4c8c-8844-e9defdc6f917)
----------------

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

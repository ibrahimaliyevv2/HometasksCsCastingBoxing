using System;

namespace PhoneStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.NotebookLimit = 2;
            store.PhoneLimit = 2;

            Notebook notebook1 = new Notebook {
                Name = "HP",
                Price = 1000
            };
            store.AddProduct(notebook1);

            Notebook notebook2 = new Notebook {
                Name = "Toshiba",
                Price = 2000
            };
            store.AddProduct(notebook2);

            Phone phone1 = new Phone {
                Name = "Iphone",
                Price = 500
            };
            store.AddProduct(phone1);

            Phone phone2 = new Phone {
                Name = "Nokia",
                Price = 1000
            };
            store.AddProduct(phone2);


            Console.WriteLine(store.FindByNo(2).Name);

            Console.WriteLine(store.CalcNotebookAvg());
            Console.WriteLine(store.CalcPhoneAvg());
        }
    }
}

using System;
namespace PhoneStore
{
    public class Store
    {
        private Product[] _products = new Product[0];

        public Product[] Products { get => _products; }
        public int NotebookLimit { get; set; }
        public int PhoneLimit { get; set; }
        public static int TotalCountNotebook = 0;
        public static int TotalCountPhone = 0;

        public void AddProduct(Product product)
        {
            if (product is Notebook && TotalCountNotebook < NotebookLimit)
            {
                Array.Resize(ref _products, _products.Length + 1);
                _products[_products.Length - 1] = product;
                TotalCountNotebook++;
            }
            else if (product is Phone && TotalCountPhone < PhoneLimit)
            {
                Array.Resize(ref _products, _products.Length + 1);
                _products[_products.Length - 1] = product;
                TotalCountNotebook++;
            }
        }


        public Product FindByNo(int no)
        {
            foreach (var item in Products)
            {
                if (item is Notebook && Notebook.No == no)
                {
                    return item;
                }
                else if (item is Phone && Phone.No == no)
                {
                    return item;
                }
            }
            return null;
        }

        public double CalcNotebookAvg()
        {
            int count = 0;
            double sum = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i] is Notebook)
                {
                    Notebook notebook = (Notebook)Products[i];
                    count++;
                    sum += notebook.Price;
                }
            }
            return sum / count;
        }

        public double CalcPhoneAvg()
        {
            int count = 0;
            double sum = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i] is Phone)
                {
                    Phone phone = (Phone)Products[i];
                    count++;
                    sum += phone.Price;
                }
            }
            return sum / count;
        }
    } }

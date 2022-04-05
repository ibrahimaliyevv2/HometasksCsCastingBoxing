using System;
namespace PhoneStore
{
    public class Notebook:Product
    {
        public Notebook()
        {
            No++;
        }

        public static int No { get; set; }
        public byte RAM { get; set; }
        public int Storage { get; set; }
    }
}

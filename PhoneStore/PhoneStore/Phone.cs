using System;
namespace PhoneStore
{
    public class Phone:Product
    {
        public Phone()
        {
            No++;
        }

        public static int No { get; set; }
        public byte SIMCount { get; set; }
    }
}

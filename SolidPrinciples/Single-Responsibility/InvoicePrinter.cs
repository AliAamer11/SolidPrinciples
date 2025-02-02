using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility
{
    public class InvoicePrinter
    {
        public Invoice Invoice { get; set; }
        public InvoicePrinter(Invoice invoice)
        {
            this.Invoice = invoice;
        }

        public void Print()
        {
            Console.WriteLine($"{Invoice.Quantity}x{Invoice.Book.Price} = {Invoice.Quantity * Invoice.Book.Price}");
            Console.WriteLine($"DiscountRate is : {Invoice.DiscountRate}");
            Thread.Sleep(1000);
        }
    }
}

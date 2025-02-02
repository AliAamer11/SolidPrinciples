using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Book book = new Book("Solid Principles", "Engineer", 2025, 400, true);
            Invoice invoice = new Invoice(4, 5, 15);
            invoice.SetBook(book);

            InvoicePrinter invoicePrinter = new InvoicePrinter(invoice);
            invoicePrinter.Print();

            InvoiceWriter invoiceWriter = new InvoiceWriter(invoice);
            invoiceWriter.WriteInvoiceAsFile();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility
{
    public class Invoice
    {
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public double DiscountRate { get; set; }
        public double TaxRate { get; set; }

        public Invoice(int quantity, double discountRate, double taxRate)
        {
            Quantity = quantity;
            DiscountRate = discountRate;
            TaxRate = taxRate;
        }

        public void SetBook(Book book) => Book = book;

    }
}

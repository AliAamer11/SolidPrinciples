namespace Single_Responsibility
{
    public class InvoiceWriter
    {
        public Invoice Invoice { get; set; }
        public InvoiceWriter(Invoice invoice)
        {
            this.Invoice = invoice;
        }

        public void WriteInvoiceAsFile()
        {
            Console.WriteLine("writing...");
            Thread.Sleep(1000);
            Console.WriteLine("writing...");
            Thread.Sleep(1000);
            Console.WriteLine("save is done.");
        }
    }
}

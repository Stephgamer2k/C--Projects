using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Vendor : iPayable
    {
        public string VendorName { get; set; }

        public double InvoiceAmount { get; set; }

        public Vendor(string vendorName, double invoiceAmount)
        {
            if(invoiceAmount < 0)
            {
                throw new ArgumentOutOfRangeException("Invoice amount cannot be negative");

            }
            else
            {
                VendorName = vendorName;
                InvoiceAmount = invoiceAmount;
            }

           
        }

        public void DisplayVendorInfo()
        {

            Console.WriteLine($"Vendor: {VendorName}, Invoice Amount: {InvoiceAmount}");
        }

        public  double CalculatePay()
        {
            return InvoiceAmount;
        }
    }
}

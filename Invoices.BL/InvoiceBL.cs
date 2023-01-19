using Invoices.DAL.Models;
using Invoices.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.BL
{
    public class InvoiceBL
    {


        public void GenerateInvoice(Invoice invoice)
        {
            string invoicePath = GetPath("98715623");
            InvoiceHelper helper = new InvoiceHelper(invoice);
            var document = helper.GenerateInvoice("file",9871563,123);
        }

        public string GetPath(string pClientID)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\OMG_bills";
            Directory.CreateDirectory(path);
            return path + "\\OMG_Cuentadecobro_" + Convert.ToString(pClientID) + ".pdf";
        }


    }
}

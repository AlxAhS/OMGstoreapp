using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using DAL.Models;
using Invoices.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using DAL.DataContext;

namespace Invoices.BLL
{
    public class ExportPDF
    {
        Client client = new Client ();
        Invoice invoice = new Invoice();
        Product product = new Product();

        public void Exportpdf()
        {
            string desktop_Path = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
            string new_Path = desktop_Path + "\\OMG_invoices";
            Directory.CreateDirectory(new_Path);

            string fileName = new_Path + "\\OMG-invoice-" + Convert.ToString(invoice.InvoiceDate) + Convert.ToString(invoice.InvoiceID) + ".pdf";


            // Must have write permissions to the path folder
            PdfWriter writer = new PdfWriter(fileName);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            LineSeparator ls = new LineSeparator(new SolidLine());

            Paragraph header = new Paragraph("OMG IMPORTS")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetBold()
               .SetFontSize(26);

            Paragraph subheader = new Paragraph("Cuenta de cobro")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(15);

            LineSeparator ls2 = new LineSeparator(new SolidLine());

            Paragraph Text1 = new Paragraph(
            "\nFecha: " + invoice.InvoiceDate + "\nCuenta de cobro N°: " + invoice.InvoiceID + "\n\n")
               .SetTextAlignment(TextAlignment.LEFT)
               .SetFontSize(14);

            Paragraph Text2 = new Paragraph(
                client.ClientName)
               .SetTextAlignment(TextAlignment.CENTER)
               .SetBold()
               .SetFontSize(20);

            Paragraph Text3 = new Paragraph(
                Convert.ToString(client.ClientID))
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(14);

            Paragraph Text4 = new Paragraph(
            "\nDebe a:")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(14);

            Paragraph Text5 = new Paragraph(
            "JOSE GABRIEL AHUMADA SOTO")
            .SetTextAlignment(TextAlignment.CENTER)
            .SetBold()
            .SetFontSize(16);

            Paragraph Text6 = new Paragraph(
            "NIT 98715623-4 (Régimen simplificado)" +
            "\nCra 57 # 27-25, Bello Antioquia" +
            "\n3127694461\n\n")
            .SetTextAlignment(TextAlignment.CENTER)
            .SetFontSize(14);

            Paragraph Text7 = new Paragraph(
            "\nLa suma de $" + product.ProductValue + " por concepto de " + product.ProductDescription + ".\n")
            .SetTextAlignment(TextAlignment.JUSTIFIED)
            .SetFontSize(12);

            Paragraph Text8 = new Paragraph(
            "\nPara efectos de retención en la fuente declaro que pertenezco a la categoría de empleado. El 80% de mis ingresos o más, provienen de ejercer mi actividad como empleado y como independiente, además soy declarante de impuesto de renta. \n\n\n\n")
            .SetTextAlignment(TextAlignment.JUSTIFIED)
            .SetFontSize(12);

            Paragraph Text9 = new Paragraph(
            "Favor pagar a nombre de ")
            .SetTextAlignment(TextAlignment.CENTER)
            .SetFontSize(12);

            Paragraph Text10 = new Paragraph(
            "JOSE GABRIEL AHUMADA SOTO ")
            .SetTextAlignment(TextAlignment.CENTER)
            .SetBold()
            .SetFontSize(14);

            Paragraph Text11 = new Paragraph(
            "por el medio de pago más conveniente.")
            .SetTextAlignment(TextAlignment.CENTER)
            .SetFontSize(12);

            //Final form: Text structure
            document.Add(header);
            document.Add(subheader);
            document.Add(ls);
            document.Add(Text1);
            document.Add(Text2);
            document.Add(Text3);
            document.Add(Text4);
            document.Add(Text5);
            document.Add(Text6);
            document.Add(Text7);
            document.Add(Text8);
            document.Add(Text9);
            document.Add(Text10);
            document.Add(Text11);

            document.Close();
        }


    }
}

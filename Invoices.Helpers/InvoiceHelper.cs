using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Invoices.DAL.Repo;
using Invoices.DAL.Models;
using DAL.DataContext;
using Microsoft.EntityFrameworkCore;

namespace Invoices.Helpers
{
    public class InvoiceHelper
    {
        private int InvoiceID;
        private DateTime InvoiceDate;
        private string? Serial;

        private readonly DatabaseContext _clientContext;
        ClientRepository clientRepo;


        private readonly DatabaseContext _productContext;
        ProductRepository productRepo;

        public InvoiceHelper(DAL.Models.Invoice invoice)
        {
            clientRepo = new ClientRepository(_clientContext);
            InvoiceID = invoice.ID;
            productRepo = new ProductRepository(_productContext);
            InvoiceDate = invoice.Date;
            Serial = invoice.Serial;
        }

        public Document GenerateInvoice(string pFilename, int pClientID, int pProductId)
        {
            // Must have write permissions to the path folder
            PdfWriter writer = new PdfWriter(pFilename);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            Client client = clientRepo.GetClient(pClientID);
            Product product = productRepo.GetbyId(pProductId);

            Paragraph Text1 = new Paragraph(
            "Fecha: " + InvoiceDate + "\nCuenta de cobro N°: " + InvoiceID)
               .SetTextAlignment(TextAlignment.RIGHT)
               .SetFontSize(10);

            Paragraph header = new Paragraph("OMG IMPORTS")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetBold()
               .SetFontSize(26);

            Paragraph subheader = new Paragraph("Cuenta de cobro")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(15);

            LineSeparator ls = new LineSeparator(new SolidLine());


            Paragraph Text2 = new Paragraph("\n" +
                client.Name)
               .SetTextAlignment(TextAlignment.CENTER)
               .SetBold()
               .SetFontSize(20);

            Paragraph Text3 = new Paragraph(
                Convert.ToString(client.ID))
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(12);

            Paragraph Text4 = new Paragraph(
            "\nDebe a:")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(12);

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
            .SetFontSize(12);

            Paragraph Text7 = new Paragraph(
            //"La suma de $")
            "La suma de $" + product.Price + " por concepto de " + product.Name + ".")
            .SetTextAlignment(TextAlignment.JUSTIFIED)
            .SetFontSize(12);

            Paragraph Text8 = new Paragraph("\nPara efectos de retención en la fuente declaro que pertenezco a la categoría de empleado. El 80% de mis ingresos o más, provienen de ejercer mi actividad como empleado y como independiente, además soy declarante de impuesto de renta.").SetTextAlignment(TextAlignment.JUSTIFIED);

            Paragraph Text9 = new Paragraph("\n\nFavor pagar a nombre de ").SetTextAlignment(TextAlignment.CENTER).SetFontSize(10);

            Paragraph Text10 = new Paragraph("JOSE GABRIEL AHUMADA SOTO ").SetTextAlignment(TextAlignment.CENTER)
            .SetFontSize(14);

            Paragraph Text11 = new Paragraph("por el medio de pago más conveniente.\n\n\n").SetTextAlignment(TextAlignment.CENTER).SetFontSize(10);

            string signaturePath = Environment.CurrentDirectory;
            Image img = new Image(ImageDataFactory
               .Create(signaturePath + "\\jahusosign.png"))
               .SetTextAlignment(TextAlignment.CENTER)
               .ScaleAbsolute(150, 35);
            //.SetFixedPosition(1, 25, 25);

            Paragraph Text12 = new Paragraph("_____________________________" + "\nJOSE GABRIEL AHUMADA SOTO" + "\nCC 98715623").SetTextAlignment(TextAlignment.LEFT);


            //Final form: Text structure
            document.Add(ls);
            document.Add(Text1);
            document.Add(header);
            document.Add(subheader);
            document.Add(ls);
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
            document.Add(img);
            document.Add(Text12);
            document.Close();
            return document;
        }
    }
}
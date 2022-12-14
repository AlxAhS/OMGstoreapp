using Invoices.DAL.Models;
using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

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
            string new_Path = desktop_Path + "\\OMG_bills";
            Directory.CreateDirectory(new_Path);

            string fileName = new_Path + "\\OMG_Cuentadecobro_" + Convert.ToString(client.ID) + ".pdf";


            // Must have write permissions to the path folder
            PdfWriter writer = new PdfWriter(fileName);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            Paragraph Text1 = new Paragraph(
            "Fecha: " + invoice.Date+ "\nCuenta de cobro N°: " + invoice.ID)
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
            "La suma de $" + product.Value + " por concepto de " + product.Item + ".")
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
        }



        public void GetPath()
        {
            //Create a method that returns the path to the export pdf method
            //Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
        }
    }
}

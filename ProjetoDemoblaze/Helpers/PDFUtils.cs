using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDemoblaze.Helpers
{
    /// <summary>
    /// 
    /// </summary>
   public class PDFUtils 
   { 

        /// <summary>
        /// 
        /// </summary>
        public void CriarPDF()
        {
            PdfWriter writer = new PdfWriter("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\PDF\\Testes.pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            Paragraph header = new Paragraph("Sucess")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(20);

            document.Add(header);
            
            LineSeparator ls = new LineSeparator(new SolidLine());
            document.Add(ls);

            Image img = new Image(ImageDataFactory
            .Create(@"C:\Users\matheus.mata\ProjetoDemoblaze\ProjetoDemoblaze\Screenshot"))
            .SetTextAlignment(TextAlignment.CENTER);
            document.Add(img);

            pdf.Close();
            document.Close();
            
        }
    }


}

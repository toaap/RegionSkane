﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//extra namespaces
using System.Diagnostics;
using MigraDoc;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.DocumentObjectModel.IO;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.Rendering;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using RegionSkane.DataAccessLayer;
using RegionSkane.Entity_Framework;
using System.IO;

namespace RegionSkane.Utils
{
    class PrintUtils
    {


        //PDF STUFF

        private Document document;
        private TextFrame addressFrame;
        private Table table;

        // ... in RGB.
        readonly static Color TableBorder = new Color(81, 125, 192);
        readonly static Color TableBlue = new Color(235, 240, 249);
        readonly static Color TableGray = new Color(242, 242, 242);

        public string[] CreateRootPath(string companyName, DateTime invoiceDate)
        {
            /*Returns array
             * [0] = whole rootpath
             * [1] = filename.pdf
             */

            string pattern = "yyyy MM";
            string[] array = new string[2];

            if (companyName == null || companyName == string.Empty || invoiceDate == null)
            {
                string newRoot = String.Format(@"C:\Users\toaap\Documents\RegionTest\{0}\Övriga\", DateTime.Now.ToString(pattern));
                Directory.CreateDirectory(newRoot);
                array[0] = newRoot;
                array[1] = invoiceDate.ToString("dd-MM-yyyy_H.mm.ss") + ".pdf";
                return array;
            }
            else
            {
                string root = String.Format(@"C:\Users\toaap\Documents\RegionTest\{0}\{1}\", invoiceDate.ToString(pattern), companyName);
                Directory.CreateDirectory(root);
                array[0] = root;
                array[1] = invoiceDate.ToString("dd-MM-yyyy_H.mm.ss") + ".pdf";
                return array;
            }
        }

        public string CreateRootPath(string contractNbr, string path)
        {
            string pattern = "dd-MM-yyyy_H.mm.ss";
            string now = DateTime.Now.ToString(pattern);
            string filename = String.Format(@"{0}\{1}-{2}.pdf",path, contractNbr, now);
            return filename;
        }

        public void CreatePdfDocuments(DataSet dataSet, List<string> savePathList, string contractNbr)
        {

            //, Handläggare handläggare, string startDate, string endDate

            int i = 0;
            foreach (DataTable dt in dataSet.Tables)
            {
                string path = savePathList[i++];
                Console.WriteLine(path);
                string filename = CreateRootPath(contractNbr, path);
                CreateDocument(dt, filename);
            }
        }

        public void CreateDocument(DataTable dt, string filename)
        {
            // Create a new MigraDoc document
            this.document = new Document();
            this.document.Info.Title = "A sample invoice";
            this.document.Info.Subject = "Demonstrates how to create an invoice.";
            this.document.Info.Author = "Stefan Lange";

            DefineStyles();

            CreatePage();

            FillContent(dt);

            // Create a renderer for PDF that uses Unicode font encoding.
            var pdfRenderer = new PdfDocumentRenderer(true);

            // Set the MigraDoc document.
            pdfRenderer.Document = document;

            // Create the PDF document.
            pdfRenderer.RenderDocument();



            // Save the PDF document...
            //var filename = "Invoice.pdf";

            // I don't want to close the document constantly...
            //filename = "Invoice-" + Guid.NewGuid().ToString("N").ToUpper() + ".pdf";




            pdfRenderer.Save(filename);
            // ...and start a viewer.
            //Process.Start(filename);




        }

        void DefineStyles()
        {
            // Get the predefined style Normal.
            Style style = this.document.Styles["Normal"];
            // Because all styles are derived from Normal, the next line changes the 
            // font of the whole document. Or, more exactly, it changes the font of
            // all styles and paragraphs that do not redefine the font.
            style.Font.Name = "Verdana";

            style = this.document.Styles[StyleNames.Header];
            style.ParagraphFormat.AddTabStop("16cm", TabAlignment.Right);

            style = this.document.Styles[StyleNames.Footer];
            style.ParagraphFormat.AddTabStop("8cm", TabAlignment.Center);

            // Create a new style called Table based on style Normal
            style = this.document.Styles.AddStyle("Table", "Normal");
            style.Font.Name = "Verdana";
            style.Font.Name = "Times New Roman";
            style.Font.Size = 9;

            // Create a new style called Reference based on style Normal
            style = this.document.Styles.AddStyle("Reference", "Normal");
            style.ParagraphFormat.SpaceBefore = "5mm";
            style.ParagraphFormat.SpaceAfter = "5mm";
            style.ParagraphFormat.TabStops.AddTabStop("16cm", TabAlignment.Right);
        }

        void CreatePage()
        {
            // Each MigraDoc document needs at least one section.
            Section section = this.document.AddSection();

            // Put a logo in the header
            Image image = section.Headers.Primary.AddImage("C:\\Region Skåne.png");
            image.Height = "2.5cm";
            image.LockAspectRatio = true;
            image.RelativeVertical = RelativeVertical.Line;
            image.RelativeHorizontal = RelativeHorizontal.Margin;
            image.Top = ShapePosition.Top;
            image.Left = ShapePosition.Right;
            image.WrapFormat.Style = WrapStyle.Through;
            section.PageSetup.TopMargin = Unit.FromCentimeter(5.0);
            //Footer margin = section.PageSetup.BottomMargin = Unit.FromCentimeter(3.0);

            // Create footer
            Paragraph paragraph = section.Footers.Primary.AddParagraph();
            paragraph.AddText("PowerBooks Inc · Sample Street 42 · 56789 Cologne · Germany");
            paragraph.Format.Font.Size = 9;
            paragraph.Format.Alignment = ParagraphAlignment.Center;

            // Create the text frame for the address
            this.addressFrame = section.AddTextFrame();
            this.addressFrame.Height = "3.0cm";
            this.addressFrame.Width = "7.0cm";
            this.addressFrame.Left = ShapePosition.Left;
            this.addressFrame.RelativeHorizontal = RelativeHorizontal.Margin;
            this.addressFrame.Top = "5.0cm";
            this.addressFrame.RelativeVertical = RelativeVertical.Page;

            // Put sender in address frame
            paragraph = this.addressFrame.AddParagraph("Region Skåne Koncerninköp");
            paragraph.Format.Font.Name = "Times New Roman";
            paragraph.Format.Font.Size = 7;
            paragraph.Format.SpaceAfter = 3;

            // Add the print date field
            paragraph = section.AddParagraph();
            paragraph.Format.SpaceBefore = "8cm";
            paragraph.Style = "Reference";
            paragraph.AddFormattedText("UPPHANDLINGSCIRKULÄR", TextFormat.Bold);
            paragraph.AddTab();
            paragraph.AddText("Malmö, ");
            paragraph.AddDateField("dd.MM.yyyy");

            // Create the item table
            this.table = section.AddTable();
            this.table.Style = "Table";
            this.table.Borders.Color = TableBorder;
            this.table.Borders.Width = 0.25;
            this.table.Borders.Left.Width = 0.5;
            this.table.Borders.Right.Width = 0.5;
            this.table.Rows.LeftIndent = 0;

            // Before you can add a row, you must define the columns
            Column column = this.table.AddColumn("1cm");
            column.Format.Alignment = ParagraphAlignment.Center;

            column = this.table.AddColumn("2.5cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = this.table.AddColumn("3cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = this.table.AddColumn("3.5cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = this.table.AddColumn("2cm");
            column.Format.Alignment = ParagraphAlignment.Center;

            column = this.table.AddColumn("4cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            // Create the header of the table
            Row row = table.AddRow();
            row.HeadingFormat = true;
            row.Format.Alignment = ParagraphAlignment.Center;
            row.Format.Font.Bold = true;
            row.Shading.Color = TableBlue;
            row.Cells[0].AddParagraph("Item");
            row.Cells[0].Format.Font.Bold = false;
            row.Cells[0].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
            row.Cells[0].MergeDown = 1;
            row.Cells[1].AddParagraph("Title and Author");
            row.Cells[1].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[1].MergeRight = 3;
            row.Cells[5].AddParagraph("Extended Price");
            row.Cells[5].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[5].VerticalAlignment = VerticalAlignment.Bottom;
            row.Cells[5].MergeDown = 1;

            row = table.AddRow();
            row.HeadingFormat = true;
            row.Format.Alignment = ParagraphAlignment.Center;
            row.Format.Font.Bold = true;
            row.Shading.Color = TableBlue;
            row.Cells[1].AddParagraph("Quantity");
            row.Cells[1].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[2].AddParagraph("Unit Price");
            row.Cells[2].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[3].AddParagraph("Discount (%)");
            row.Cells[3].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[4].AddParagraph("Taxable");
            row.Cells[4].Format.Alignment = ParagraphAlignment.Left;

            this.table.SetEdge(0, 0, 6, 2, Edge.Box, BorderStyle.Single, 0.75, Color.Empty);
        }

        void FillContent(DataTable dt)
        {

            // Fill the address in the address text frame.
            var paragraph = addressFrame.AddParagraph();
            paragraph.AddText("Region Skåne Koncern");
            paragraph.AddLineBreak();
            paragraph.AddText("Malmö...");
            paragraph.AddLineBreak();
            paragraph.AddText("23651 Sverige");


            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {

                    // Each item fills two rows.
                    var row1 = this.table.AddRow();
                    var row2 = this.table.AddRow();
                    row1.TopPadding = 1.5;
                    row1.Cells[0].Shading.Color = TableGray;
                    row1.Cells[0].VerticalAlignment = VerticalAlignment.Center;
                    row1.Cells[0].MergeDown = 1;
                    row1.Cells[1].Format.Alignment = ParagraphAlignment.Left;
                    row1.Cells[1].MergeRight = 3;
                    row1.Cells[5].Shading.Color = TableGray;
                    row1.Cells[5].MergeDown = 1;

                    string apa = row["06Benämning 1"].ToString();

                    Console.WriteLine(apa + row[1].ToString());

                    row1.Cells[0].AddParagraph();
                    paragraph = row1.Cells[1].AddParagraph(apa);
                    var formattedText = new FormattedText() { Style = "Title" };
                    formattedText.AddText(row[1].ToString());
                    paragraph.Add(formattedText);
                    paragraph.AddFormattedText(" by ", TextFormat.Italic);
                    paragraph.AddText(row[2].ToString());

                    row2.Cells[1].AddParagraph(apa);
                    row2.Cells[2].AddParagraph(apa + " €");

                    row2.Cells[4].AddParagraph();
                    row2.Cells[5].AddParagraph(apa);

                    row1.Cells[5].AddParagraph(row["06Benämning 1"].ToString() + " €");
                    row1.Cells[5].VerticalAlignment = VerticalAlignment.Bottom;

                    table.SetEdge(0, table.Rows.Count - 2, 6, 2, Edge.Box, BorderStyle.Single, 0.75);

                    // Add an invisible row as a space line to the table.
                    var rows = table.AddRow();
                    rows.Borders.Visible = false;

                    rows = table.AddRow();
                    rows.Cells[0].Borders.Visible = false;
                    rows.Cells[0].AddParagraph(row["06Benämning 1"].ToString());
                    rows.Cells[5].AddParagraph(0.ToString("0.00") + " €");
                    rows.Cells[0].Format.Font.Bold = true;
                    rows.Cells[0].Format.Alignment = ParagraphAlignment.Right;
                    rows.Cells[0].MergeRight = 4;

                }
            }


            /*
            // Iterate the invoice items.
            double totalExtendedPrice = 0;
            var iter = _navigator.Select("/invoice/items/*");
            while (iter.MoveNext())
            {
                item = iter.Current;
                var quantity = GetValueAsDouble(item, "quantity");
                var price = GetValueAsDouble(item, "price");
                var discount = GetValueAsDouble(item, "discount");

                // Each item fills two rows.
                var row1 = this.table.AddRow();
                var row2 = this.table.AddRow();
                row1.TopPadding = 1.5;
                row1.Cells[0].Shading.Color = TableGray;
                row1.Cells[0].VerticalAlignment = VerticalAlignment.Center;
                row1.Cells[0].MergeDown = 1;
                row1.Cells[1].Format.Alignment = ParagraphAlignment.Left;
                row1.Cells[1].MergeRight = 3;
                row1.Cells[5].Shading.Color = TableGray;
                row1.Cells[5].MergeDown = 1;

                row1.Cells[0].AddParagraph(GetValue(item, "itemNumber"));
                paragraph = row1.Cells[1].AddParagraph();
                var formattedText = new FormattedText() { Style = "Title" };
                formattedText.AddText(GetValue(item, "title"));
                paragraph.Add(formattedText);
                paragraph.AddFormattedText(" by ", TextFormat.Italic);
                paragraph.AddText(GetValue(item, "author"));
                row2.Cells[1].AddParagraph(GetValue(item, "quantity"));
                row2.Cells[2].AddParagraph(price.ToString("0.00") + " €");
                if (discount > 0)
                    row2.Cells[3].AddParagraph(discount.ToString("0") + '%');
                row2.Cells[4].AddParagraph();
                row2.Cells[5].AddParagraph(price.ToString("0.00"));
                var extendedPrice = quantity * price;
                extendedPrice = extendedPrice * (100 - discount) / 100;
                row1.Cells[5].AddParagraph(extendedPrice.ToString("0.00") + " €");
                row1.Cells[5].VerticalAlignment = VerticalAlignment.Bottom;
                totalExtendedPrice += extendedPrice;

                _table.SetEdge(0, _table.Rows.Count - 2, 6, 2, Edge.Box, BorderStyle.Single, 0.75);
            }

            // Add an invisible row as a space line to the table.
            var row = _table.AddRow();
            row.Borders.Visible = false;

            // Add the total price row.
            row = _table.AddRow();
            row.Cells[0].Borders.Visible = false;
            row.Cells[0].AddParagraph("Total Price");
            row.Cells[0].Format.Font.Bold = true;
            row.Cells[0].Format.Alignment = ParagraphAlignment.Right;
            row.Cells[0].MergeRight = 4;
            row.Cells[5].AddParagraph(totalExtendedPrice.ToString("0.00") + " €");
            row.Cells[5].Format.Font.Name = "Segoe UI";

            // Add the VAT row.
            row = _table.AddRow();
            row.Cells[0].Borders.Visible = false;
            row.Cells[0].AddParagraph("VAT (7%)");
            row.Cells[0].Format.Font.Bold = true;
            row.Cells[0].Format.Alignment = ParagraphAlignment.Right;
            row.Cells[0].MergeRight = 4;
            row.Cells[5].AddParagraph((0.07 * totalExtendedPrice).ToString("0.00") + " €");

            // Add the additional fee row.
            row = _table.AddRow();
            row.Cells[0].Borders.Visible = false;
            row.Cells[0].AddParagraph("Shipping and Handling");
            row.Cells[5].AddParagraph(0.ToString("0.00") + " €");
            row.Cells[0].Format.Font.Bold = true;
            row.Cells[0].Format.Alignment = ParagraphAlignment.Right;
            row.Cells[0].MergeRight = 4;

            // Add the total due row.
            row = _table.AddRow();
            row.Cells[0].AddParagraph("Total Due");
            row.Cells[0].Borders.Visible = false;
            row.Cells[0].Format.Font.Bold = true;
            row.Cells[0].Format.Alignment = ParagraphAlignment.Right;
            row.Cells[0].MergeRight = 4;
            totalExtendedPrice += 0.19 * totalExtendedPrice;
            row.Cells[5].AddParagraph(totalExtendedPrice.ToString("0.00") + " €");
            row.Cells[5].Format.Font.Name = "Segoe UI";
            row.Cells[5].Format.Font.Bold = true;

            // Set the borders of the specified cell range.
            _table.SetEdge(5, _table.Rows.Count - 4, 1, 4, Edge.Box, BorderStyle.Single, 0.75);

            // Add the notes paragraph.
            paragraph = _document.LastSection.AddParagraph();
            paragraph.Format.Alignment = ParagraphAlignment.Center;
            paragraph.Format.SpaceBefore = "1cm";
            paragraph.Format.Borders.Width = 0.75;
            paragraph.Format.Borders.Distance = 3;
            paragraph.Format.Borders.Color = TableBorder;
            paragraph.Format.Shading.Color = TableGray;
            item = SelectItem("/invoice");
            paragraph.AddText(GetValue(item, "notes"));
        }
             * */

        }

    }
}

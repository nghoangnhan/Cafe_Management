using System.Xml;
using Xceed.Words.NET;
using Xceed.Document.NET;
using Font = Xceed.Document.NET.Font;
using Formatting = Xceed.Document.NET.Formatting;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System;
using System.Data;
using CoffeeShop.DAO;

namespace CoffeeShop
{
    public class Print
    {
        public void exportDataToWord(DataGridView DGV, string chxh, string dltd, string total, string filename)
        {

            #region one
            string fileName = "Báo cáo thu chi.docx";
            var doc = DocX.Create(fileName);
            #endregion

            #region two
            string title = "Báo cáo thu chi";

            Formatting titleFormat = new Formatting();
            titleFormat.FontFamily = new Font("Arial");
            titleFormat.Size = 20D;
            titleFormat.Position = 40;
            titleFormat.FontColor = Color.Black;
            titleFormat.UnderlineColor = Color.Black;
            titleFormat.Italic = true;

            Formatting chxhFormat = new Formatting();
            chxhFormat.FontFamily = new Font("Arial");
            chxhFormat.Size = 20D;
            chxhFormat.Position = 0;
            chxhFormat.FontColor = Color.Black;
            chxhFormat.Bold = true;

            Formatting dltdFormat = new Formatting();
            dltdFormat.FontFamily = new Font("Arial");
            dltdFormat.Size = 15D;
            dltdFormat.Position = 0;
            dltdFormat.FontColor = Color.Black;
            dltdFormat.Bold = true;

            Formatting totalFormat = new Formatting();
            totalFormat.FontFamily = new Font("Arial");
            totalFormat.Size = 15D;
            totalFormat.Position = 0;
            totalFormat.FontColor = Color.Black;
            totalFormat.UnderlineColor = Color.Black;

            //Formatting Text Paragraph  
            Formatting textParagraphFormat = new Formatting();
            //font family  
            textParagraphFormat.FontFamily = new Font("Arial");
            //font size  
            textParagraphFormat.Size = 12D;
            //Spaces between characters  
            textParagraphFormat.Spacing = 1;
            //Insert title  

            Paragraph paragraphchxh = doc.InsertParagraph(chxh, false, chxhFormat);
            paragraphchxh.Alignment = Alignment.center;

            Paragraph paragraphdltd = doc.InsertParagraph(dltd, false, dltdFormat);
            paragraphdltd.Alignment = Alignment.center;

            DateTime date = DateTime.Now;
            Paragraph paragraphdate = doc.InsertParagraph("Hồ Chí Minh, " + date.ToString(), false, textParagraphFormat);
            paragraphdate.Alignment = Alignment.right;

            Paragraph paragraphTitle = doc.InsertParagraph(title, false, titleFormat);
            paragraphTitle.Alignment = Alignment.center;

            Paragraph paragraphtotal = doc.InsertParagraph(total, false, totalFormat);
            paragraphtotal.Alignment = Alignment.left;

            //Insert text  
            //doc.InsertParagraph(textParagraph, false, textParagraphFormat);
            #endregion

            #region four
            doc.InsertParagraph();
            //Create Table
            //var listPlayer = CreateInitData();


            // Fill cells by adding text.  
            // First row
            //
            int temp = DGV.Rows.Count;

            Xceed.Document.NET.Table table = doc.AddTable(temp + 1, DGV.Columns.Count);
            table.Alignment = Alignment.center;
            table.Design = TableDesign.TableGrid;
            table.Rows[0].Cells[0].Paragraphs.First().Append("Số hóa đơn");
            table.Rows[0].Cells[1].Paragraphs.First().Append("Số Order");
            table.Rows[0].Cells[2].Paragraphs.First().Append("Mã nhân viên");
            table.Rows[0].Cells[3].Paragraphs.First().Append("Mã khách hàng");
            table.Rows[0].Cells[4].Paragraphs.First().Append("Ngày in hóa đơn");
            table.Rows[0].Cells[5].Paragraphs.First().Append("Tổng hóa đơn");
            table.Rows[0].Cells[6].Paragraphs.First().Append("Mô tả hóa đơn");

            Paragraph para = doc.InsertParagraph("", false, titleFormat);
            int m = 0;
            for (int i = 1; i <= temp; i++)
            {
                System.Data.DataTable tablestudent = (System.Data.DataTable)DGV.DataSource;

                for (int j = 0; j < DGV.Columns.Count; j++)
                {
                    table.Rows[i].Cells[j].Paragraphs.First().Append(tablestudent.Rows[m][j].ToString());
                }
                m++;
            }
            doc.InsertTable(table);
            #endregion
            #region part of one
            doc.Save();
            Process.Start("WINWORD.EXE", fileName);
            #endregion
            Console.Read();
        }
    }
}

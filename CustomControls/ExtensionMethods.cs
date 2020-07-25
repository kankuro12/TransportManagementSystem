using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace CustomControls
{
    public static class ExtensionMethods
    {
        public static string ToNepaliDate(this int date)
        {
            var str = "";
            str = (date / 10000).ToString();
            date = date % 10000;
            str += "/" + (date / 100).ToString("00");
            date = date % 100;
            str += "/" + date.ToString("00");
            return str;
        }

        public static int[] ToNepaliDateArray(this int date)
        {
            var str = new int[] { 0, 0, 0 };
            str[0] = (date / 10000);
            date = date % 10000;
            str [1]=  (date / 100);
            date = date % 100;
            str[2]=date;
            return str;
        }
        public static bool ISNumber(this string s)
        {
            decimal n = 0;
            return decimal.TryParse(s, out n);
        }
        /// <summary>
        /// Export Data To Excel
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="path"></param>
        public static void ToExcel(this ListView listView,string title, string path)
        {
            //using (var package = new ExcelPackage())
            //{
            //    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(title);
            //    var i = 1;
            //    var j = 1;
            //    foreach (ColumnHeader item in listView.Columns)
            //    {
            //        worksheet.Cells[i, j].Value = item.Text;
            //    }
            //    i += 1;
            //    foreach (ListViewItem item in listView.Items)
            //    {
            //        j = 0;
            //        foreach (ListViewItem.ListViewSubItem itm in item.SubItems)
            //        {
            //            worksheet.Cells[i, j].Value = itm.Text;


            //        }
            //        i += 1;
            //    }
            //    var f = new FileInfo(path);
            //    package.SaveAs(f);
            //}
        }

        public static void AddColumns(this ListView listView,string[] s)
        {
            foreach (var item in s)
            {
                listView.Columns.Add(new ColumnHeader()
                {
                    Text = item
                });
            }
        }

        public static void MakeMiddle(this Control c)
        {
            if (c.Parent != null)
            {
                c.Top = (c.Parent.Height - c.Height) / 2;
                c.Left = (c.Parent.Width - c.Width) / 2;
            }
        }

        public static void SetOtherBorder(this Control c,Color cc,float w=1)
        {
            c.Paint += (o, e) =>
            {
                e.Graphics.DrawRectangle(new Pen(new SolidBrush(cc), w), new Rectangle(0, 0, c.Width -(int) w - 1, c.Height- (int)w - 1));
            };
        }

        public static bool checkconn(this string connectionstring)
        {

            try
            {
                using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionstring))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Debug.WriteLine(ex.Message + Environment.NewLine +
                    "Error line: " + ex.LineNumber + Environment.NewLine +
                    "Procedure name: " + ex.Procedure);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }
    }
}

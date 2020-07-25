using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.IO;
namespace CustomControls
{
    public class PrintObject
    {
        public PageSettings PageSettings { get; set; }
        public PrinterSettings PrinterSettings { get; set; }
        public string name { get; set; }

        public PrintDocument PrintDocument { get; set; }
        public PrintDialog PrintDialog { get; set; }
        public PageSetupDialog PageSetupDialog { get; set; }
        public bool initiated { get; set; }

        public dynamic printingHolder { get; set; }

        public void initUI()
        {
            PrintDocument = new PrintDocument();
            PrintDialog = new PrintDialog();
            PrintDialog.Document = PrintDocument;
            PageSetupDialog = new PageSetupDialog();
            PageSetupDialog.Document = PrintDocument;


    
        }

       

        public void refresh()
        {
            if (initiated)
            {
                PrintDocument.DefaultPageSettings = PageSettings;
                PrintDocument.PrinterSettings = PrinterSettings;
            }
        }

        public void setupPrinter()
        {
            try
            {
                if (PrintDialog.ShowDialog()==DialogResult.OK)
                {
                   PrinterSettings = PrintDialog.PrinterSettings;
                    BinarySerialization.WriteToBinaryFile<PrinterSettings>(name + "-printer.bin", PrinterSettings, false);

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void setupPaper()
        {
            try
            {
                if (PageSetupDialog.ShowDialog() == DialogResult.OK)
                {
                    PageSettings = PageSetupDialog.PageSettings;
                    BinarySerialization.WriteToBinaryFile<PageSettings>(name + "-page.bin", PageSettings, false);

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool loaddata()
        {
            if (!File.Exists(name + "-printer.bin")|| !File.Exists(name + "-page.bin"))
            {
                return false;
            }

            try
            {
                this.PrinterSettings = BinarySerialization.ReadFromBinaryFile<PrinterSettings>(this.name + "-printer.bin");
                this.PageSettings = BinarySerialization.ReadFromBinaryFile<PageSettings>(this.name + "-page.bin");
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public void resetup()
        {
            
            try
            {

                setupPrinter();
                setupPaper();
                refresh();
                initiated = true;
            }
            catch (Exception ex)
            {

                initiated = false;
            }
        }

        public PrintObject(string name)
        {
            this.name = name;
            initUI();
            initiated = loaddata();
            if (initiated)
            {
                refresh();
            }
            else
            {
                resetup();
            }

            
        }
    }
}

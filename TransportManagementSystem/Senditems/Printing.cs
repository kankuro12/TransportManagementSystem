using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
namespace TransportManagementSystem.Senditems
{
    public class Printing
    {
        private CustomControls.PrintObject PrintObject;
        public Model.trip Trip { get; set; }

        double[] ratio = new double[] { 0, 0.02, 0.1, 0.02, 0.1, 0.05, 0.1, 0, 0.1, 0.1, 0.1, 0.05, 0.05, 0.02, 0.02, 0.05, 0.09 };
        int offset = 0;
        BetterListView bs;
        public void prininte(Model.trip trip, BetterListView _bs = null)

        {
            bs = _bs;
            Trip = trip;
            if (this.PrintObject == null)
            {

                this.PrintObject = new CustomControls.PrintObject("transport");
                this.PrintObject.PrintDocument.PrintPage += PrintDocument_PrintPage;
            }
            offset = 0;
            this.PrintObject.PrintDocument.Print();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var top = 10;
            var left = 10;
            var w = e.PageSettings.Bounds.Width - 20;
            var h = e.PageSettings.Bounds.Height;
            var g = e.Graphics;

            top += g.printInBox(left, top, w, "Transport Management System", PrintHelper.f_20_bold, System.Drawing.StringAlignment.Center);
            top += g.printInBox(left, top, w, "Khanar 1 Sunsari", PrintHelper.f_10_bold, System.Drawing.StringAlignment.Center);
            top += g.printInBox(left, top, w, "9816985815", PrintHelper.f_7, System.Drawing.StringAlignment.Center);
            top += g.printInBox(left, top, w, "Invoice No:" + Trip.id.ToString(), PrintHelper.f_7_bold, System.Drawing.StringAlignment.Near);
            top += g.printInBox(left, top, w, "Staff Name:" + Trip.vehicle.vehicle_no, PrintHelper.f_8, System.Drawing.StringAlignment.Near);
            top += g.printInBox(left, top, w, "Staff Name:" + Trip.vehicle.staff.name, PrintHelper.f_8, System.Drawing.StringAlignment.Near);
            top += g.printInBox(left, top, w, "Date:" + Trip.date.ToString(), PrintHelper.f_7, System.Drawing.StringAlignment.Far);
            top += 10;
            g.DrawLine(Pens.Black, left, top, left + w, top);
            top += 5;
            var temptop = top;

            top += PrintHelper.drawtext(g,
                        new string[] {

                    "S.N",
                    "Sender Name&Phone",
                    "Receiver Name&Phone",
                    "Item Name",
                    "From",
                    "To",
                    "Deliver Place",
                    "qty",
                    "weight",
                    "c.Amount"

                     },
                        new double[]
                        {
                      0,0.03,0.15,0.15,0.16,0.12,0.12,0.12,.05,0.05,0.05
                        }, top, w - 10, PrintHelper.f_7, Brushes.Black
                         ) + 5;
            var bis = DB.Instance.tripitems.Where(o => o.bill_id == Trip.id).ToList();
            for (int i = offset; i < bis.Count; i++)
            {
                if (top + 50 > h - 20)
                {
                    g.drawlines(new double[]
                        {
                      0,0.03,0.15,0.15,0.16,0.12,0.12,0.12,.05,0.05,0.05 },
                        temptop, w-10, top - temptop, left);
                    offset = i;
                    e.HasMorePages = true;
                    return;
                }
                g.DrawLine(Pens.Black, left, top, left + w, top);
                var item = bis.ElementAt(i);
                var itemname = DB.Instance.orderitemlists.Find(item.item_id).itemname;
                top += PrintHelper.drawtext(g,
                       new string[] {

                    (i+1).ToString(),
                    item.sender_name+"\n"+item.sender_phone,
                    item.receivername+"\n"+item.receiverphone,
                    itemname,
                    item.location.name,
                    item.location1.name,
                    item.deliver_place.ToString(),
                    item.quantity.Value.ToString("0.###"),
                    item.weight.Value.ToString("0.###")+" "+ item.unit.ToString(),
                    item.amount.Value.ToString("0.##")
                    },
                      new double[]
                        {
                       0,0.03,0.15,0.15,0.16,0.12,0.12,0.12,.05,0.05,0.05
                        }, top, w - 10, PrintHelper.f_7, Brushes.Black
                         ) + 5;
            }

            g.drawlines(new double[]
                        {
                      0,0.03,0.15,0.15,0.16,0.12,0.12,0.12,.05,0.05,0.05
                        },
                        temptop, w-10, top - temptop, left);
        }
    }
}

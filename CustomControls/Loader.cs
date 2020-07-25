using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class Loader : Form
    {
        public delegate void initHandler();
        public event initHandler init;

       
        Graphics g;
        int degree;
        Color color;
        Pen p;
        bool inited = false;
        public bool finished = false;
        public Loader()
        {
            InitializeComponent();
            this.TopLevel = true;
            color = Color.FromArgb(0, 149, 255);
            degree = 0;
            p = new Pen(new SolidBrush(color), 5);
            this.FormClosing += (o, e) =>
            {
                if (!finished)
                {
                    e.Cancel = true;
                }
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!inited)
                {
                    new Thread(() =>
                    {

                        init?.Invoke();
                    }).Start();
                    inited = true;
                }
                if (this.finished)
                {
                    this.Close();
                }
                g.Clear(Color.White);
                g.DrawArc(p, new Rectangle(15, 15, 120, 120), degree, degree + 60);
                degree += 5;
                if (degree+60 > 360)
                {
                    degree = 0;
                }

            }
            catch (Exception)
            {

               
            }
        }

        private void Loader_Load(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            timer1.Enabled = true;
        }


    }
}

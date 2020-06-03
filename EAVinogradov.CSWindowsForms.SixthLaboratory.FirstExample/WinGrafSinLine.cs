using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAVinogradov.CSWindowsForms.SixthLaboratory.FirstExample
{
    public partial class WinGrafSinLine : Form
    {
        public double a, b;
        public WinGrafSinLine()
        {
            InitializeComponent();
            a = 0.1;
            b = 0.04;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            double t = 0;
            Point p1, p2;
            int w = (int)panel1.Width;
            int h = (int)panel1.Height;
            int y = h / 2;

            for (int x = 0; x < w; x++)
            {
                p1 = new Point(x, y);
                t = Operation.SummSin(x, a, b);
                y = (int)(t * h / 5);
                y = y + h / 2;
                p2 = new Point(x, y);
                Graphics dc = e.Graphics;
                Pen p = new Pen(Color.Red, 1);
                dc.DrawLine(p, p1, p2);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            EditForm editF = new EditForm();
            editF.Show(this);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                panel1.Refresh();
            }
            catch (Exception er)
            {
                MessageBox.Show("При выполнении ввода исходных данных возникла ошибка: \n" + er.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
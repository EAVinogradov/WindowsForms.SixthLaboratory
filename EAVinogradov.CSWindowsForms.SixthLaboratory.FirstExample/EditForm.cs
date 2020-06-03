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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            WinGrafSinLine frmOne = this.Owner as WinGrafSinLine;
                try
                {
                    frmOne.a = double.Parse(textBox1.Text);
                    frmOne.b = double.Parse(textBox2.Text);
                }
                catch (Exception er)
                {
                    MessageBox.Show("При выполнении ввода исходных данных возникла ошибка: \n" + er.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Close();
                frmOne.Refresh();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract_Class_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Kedi kedi = new Kedi();
            kedi.renk = "Beyaz";
            kedi.yas = 4;
            MessageBox.Show(kedi.renk + " " + kedi.yas + " " + kedi.Ses() + " " + kedi.Yemek());

            Kopek kopek = new Kopek();
            kopek.renk = "Siyah";
            kopek.yas = 3;
            MessageBox.Show(kopek.renk + " " + kopek.yas + " " + kopek.Ses() + " " + kopek.Yemek());
        }
    }
}
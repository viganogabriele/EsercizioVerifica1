using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsercizioVerifica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lst.Items.Add("patate");
            lst.Items.Add("ciliegie");
            lst.Items.Add("avocado");
            lst.Items.Add("carote");
            lst.Items.Add("zucchine");
            lst.Items.Add("pomodirini");
            lst.Items.Add("lattuga");
            lst.Items.Add("broccoli");
        }

        double[] prezzi = { 1.00, 3.50, 4.00, 0.50, 0.50, 2.38, 1.68, 2.00 };
        double prezzo = 0;
        private void btn_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < prezzi.Length; i++)
            {
                if(lst.GetSelected(i) == true)
                {
                    prezzo += prezzi[i];
                }
            }
            lbl.Text = prezzo.ToString();
        }

        private void btnAzzera_Click(object sender, EventArgs e)
        {
            prezzo = 0;
            lbl.Text = prezzo.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decorrr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rain rain1 = new HeavyRain();
            rain1 = new IceRain(rain1); 
            MessageBox.Show("Назва:"+ rain1.Name);
            MessageBox.Show("Кількість опадів:"+ rain1.GetCost());

            Rain rain2 = new HeavyRain();
            rain2 = new ThunderstormRain(rain2);
            MessageBox.Show("Назва:"+ rain2.Name);
            MessageBox.Show("Кількість опадів:"+ rain2.GetCost());

            Rain rain3 = new LightRain();
            rain3 = new IceRain(rain3);
            rain3 = new ThunderstormRain(rain3);
            MessageBox.Show("Назва:"+ rain3.Name);
            MessageBox.Show("Кількість опадів:"+ rain3.GetCost());
        }
    }
}

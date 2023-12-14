using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projLeds
{
    public partial class Form1 : Form
    {

        private Leds l;
        public Form1()
        {
            InitializeComponent();
            l = new Leds(129);
            atualizaInterface();
        }

        private void atualizaInterface()
        {
            label1.Text = l.getEstado().ToString();
            label2.Text = Convert.ToString(l.getEstado(), 2);
            btnLed1.Text = (l.getEstado(8) ? "OFF" : "ON");
            btnLed2.Text = (l.getEstado(7) ? "OFF" : "ON");
            btnLed3.Text = (l.getEstado(6) ? "OFF" : "ON");
            btnLed4.Text = (l.getEstado(5) ? "OFF" : "ON");
            btnLed5.Text = (l.getEstado(4) ? "OFF" : "ON");
            btnLed6.Text = (l.getEstado(3) ? "OFF" : "ON");
            btnLed7.Text = (l.getEstado(2) ? "OFF" : "ON");
            btnLed8.Text = (l.getEstado(1) ? "OFF" : "ON");


            picLed.Image = (l.getEstado(8)) ?
                projLeds.Properties.Resources.aceso:
                projLeds.Properties.Resources.apagado;
            picLed2.Image = (l.getEstado(7)) ?
                  projLeds.Properties.Resources.aceso :
                  projLeds.Properties.Resources.apagado;
            picLed3.Image = (l.getEstado(6)) ?
                projLeds.Properties.Resources.aceso :
                projLeds.Properties.Resources.apagado;
            picLed4.Image = (l.getEstado(5)) ?
                projLeds.Properties.Resources.aceso :
                projLeds.Properties.Resources.apagado;
            picLed5.Image = (l.getEstado(4)) ?
                projLeds.Properties.Resources.aceso :
                projLeds.Properties.Resources.apagado;
            picLed6.Image = (l.getEstado(3)) ?
                projLeds.Properties.Resources.aceso :
                projLeds.Properties.Resources.apagado;
            picLed7.Image = (l.getEstado(2)) ?
                projLeds.Properties.Resources.aceso :
                projLeds.Properties.Resources.apagado;
            picLed8.Image = (l.getEstado(1)) ?
                projLeds.Properties.Resources.aceso :
                projLeds.Properties.Resources.apagado;





        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qualLed;

            qualLed = int.Parse(((Button)sender).Tag.ToString());

            if (l.getEstado(qualLed))
                l.apagar(qualLed);
            else
                l.acender(qualLed);
            atualizaInterface();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

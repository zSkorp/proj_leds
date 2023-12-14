using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLeds
{
    internal class Leds
    {
        private byte dado;
        public Leds()
        {
            this.dado = 0;
        }
        public Leds(byte dado)
        {
            this.dado = dado;
        }
        public void setDado(byte dado)
        {
            this.dado = dado;
        }
        public void acender(int led)
        {
            this.dado = (byte)((int)this.dado | (int)Math.Pow(2, led - 1));
        }
        public void apagar(int led)
        {
            this.dado = (byte)((int)this.dado & (int)(255 - Math.Pow(2, led - 1)));
        }
        public bool getEstado(int led)
        {
            byte aux;
            aux = (byte)((int)this.dado & (int)Math.Pow(2, led - 1));
            return (aux > 0);
        }

        public byte getEstado()
        {
            return this.dado;   
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Heladera:Electrodomesticos
    {
        private string Tipoderefrigerador;
        private int Capacidaddelrefrigerador;
        public Heladera()
        {
            Tipoderefrigerador = "Congelador";
            Capacidaddelrefrigerador = 40;
        }
        public string GetTipoderefrigerador()
        {
            return Tipoderefrigerador;
        }
        public int GetCapacidaddelrefrigerador()
        {
            return Capacidaddelrefrigerador;
        }
        public void SetTipoderefrigerador(string n)
        {
            Tipoderefrigerador = n;
        }
        public void SetCapacidaddelrefrigerador(int n)
        {
            Capacidaddelrefrigerador = n;
        }
        public float GetPrecioFinal(float n)
        {
            if(Capacidaddelrefrigerador>50)
            {
                if(Tipoderefrigerador=="Frigorifico")
                {
                    return n + 60;
                }
                else
                {
                    return n + 100;
                }
            }
            return n;
        }
    }
}

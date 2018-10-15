using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_cosina
{
    class Cocina : Electrodomestico
    {
        private int  Profundidad, Alto, Ancho;
        private string Alimentación;
        
        
        public Cocina() // contructor por defecto 
        {
            Ancho = 65 / 100;
            Alto = 85 / 100;
            Profundidad = 65 / 100;
            Alimentación = "Gas";
        }
        public int GetAncho()
        {
            return Ancho;
        }
        public int GetAlto()
        {
            return Alto;
        }
        public int GetProfundidad()
        {
            return Profundidad;
        }
        public string GetAlimentacion()
        {
            return this.Alimentación;
        }
        public void  SetAncho (int nuevovalor)
        {
            Ancho = nuevovalor;
        }
        public void SetAlto(int nuevovalor)
        {
            Alto = nuevovalor;
        }
        public void SetProfundidad(int nuevovalor)
        {
            Profundidad = nuevovalor;
        }
        public void SetAlimentacion(string nuevovalor)
        {
            Alimentación = nuevovalor;
        }
        public float GetPrecio(float PrecioFinal)
        {
            if ((Ancho >= 60) && (Ancho <= 79))
            {
                return PrecioFinal*15/100 + PrecioFinal; 
            }
            if ((Ancho >= 80) && (Ancho <= 99))
            {
                return PrecioFinal * 20 / 100 + PrecioFinal;
            }
            if (Ancho >= 100)
            {
                return PrecioFinal * 30 / 100 + PrecioFinal;
            }
            return PrecioFinal;
        }
    }
}

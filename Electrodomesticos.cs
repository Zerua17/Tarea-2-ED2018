using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Electrodomesticos
    {
        private String color;
        private String consumoenergetico;
        private float precio;
        private float peso;

        public Electrodomesticos()
        {
            color = "blanco";
            consumoenergetico = "F";
            peso = 5;
            precio = 0;
        }
        public string Getcolor()
        {
            return this.color;
        }
        public void Setcolor(string color)
        {
            this.color = color;
        }
        public string Getconsumoenergito()
        {
            return this.consumoenergetico;
        }
        public void Setconsumoenergetico(string consumoenergito)
        {
            this.consumoenergetico = consumoenergito;
        }
        public float Getprecio()
        {

            return this.precio;
        }
        public void Setprecio(float precio)
        {
            this.precio = precio;
        }
        public float Getpeso()
        {
            return this.peso;
        }
        public void Setpeso(float peso)
        {
            this.peso = peso;

        }
    }
}

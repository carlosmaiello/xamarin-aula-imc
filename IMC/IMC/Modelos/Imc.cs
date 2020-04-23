using System;
using System.Collections.Generic;
using System.Text;

namespace IMC.Modelos
{
    public class Imc
    {
        public DateTime Data { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public double Valor
        {
            get
            {
                return this.Peso / (this.Altura * this.Altura);
            }
        }

        public override string ToString()
        {
            return "IMC: " + this.Valor + ", Altura: " + this.Altura + ", Peso: " + this.Peso;
        }
    }
}

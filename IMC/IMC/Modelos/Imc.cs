using System;
using System.Collections.Generic;
using System.Text;

namespace IMC.Modelos
{
    class Imc
    {
        public Usuario Usuario { get; set; }
        public DateTime Data { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public double Valor
        {
            get
            {
                return Peso / (Altura * Altura);
            }
        }

        public String Mensagem
        {
            get
            {
                return "IMC: " + Valor + " Peso: " + Peso + " Altura: " + Altura;
            }
        }
    }
}

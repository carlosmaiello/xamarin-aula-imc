using System;
using System.Collections.Generic;
using System.Text;

namespace IMC.Modelos
{
    class Usuario
    {
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public List<Imc> Imcs { get; set; }
    }
}

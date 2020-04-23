using System;
using System.Collections.Generic;
using System.Text;

namespace IMC.Modelos
{
    public class Usuario
    {
        public String Nome {get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
        public double Altura { get; private set; }
        public double Peso { get; private set; }

        public List<Imc> Imcs { get; set; }

        public Usuario ()
        {
            this.Imcs = new List<Imc>();
        }

        public Imc NovoPeso(double peso)
        {
            this.Peso = peso;

            Imc imc = CriarImc();

            return imc;
        }

        public Imc NovaAltura(double altura)
        {
            this.Altura = altura;

            Imc imc = CriarImc();


            return imc;
        }

        public Imc NovaAlturaPeso(double altura, double peso)
        {
            this.Peso = peso;
            this.Altura = altura;

            Imc imc = CriarImc();
            return imc;
        }

        private Imc CriarImc()
        {
            Imc imc = new Imc();
            imc.Data = new DateTime();
            imc.Altura = this.Altura;
            imc.Peso = this.Peso;

            Imcs.Add(imc);

            return imc;
        }
    }
}

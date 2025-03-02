using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppEsercizietto
{
    public class Appartamento
    {
        private int civico;
        private string tipo;

        public int Civico { get { return civico; } set { civico = value; } }
        public string Tipo { get { return tipo; } set { tipo = value; } }

        public Appartamento(int civico, string tipo) 
        {
            this.civico = civico;
            this.tipo = tipo;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppEsercizietto
{
    public class Cliente
    {
        string nome, cognome, cod_Fis;

        public string Nome { get {  return nome; } set { nome = value; } }
        public string Cognome { get { return cognome; } set { cognome = value; } }
        public string Cod_Fis { get { return cod_Fis; } set { cod_Fis = value; } }

        
    }
}

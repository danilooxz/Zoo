using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zologico.classes
{
    public abstract class Tratador
    {
        public string NomeTradator { get; set; }

        public Tratador(string nomeTratador)
        {
            NomeTradator = nomeTratador;
        }
    }
}

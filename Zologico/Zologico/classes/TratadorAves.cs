using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zologico.interfaces;

namespace Zologico.classes
{
    public class TratadorAves : Tratador, ICuidavel
    {
        public TratadorAves(string nome) : base (nome)
        {

        }

        public void Cuidar()
        {
            Console.WriteLine($"{NomeTradator} está cuidando");
        }
    }
}

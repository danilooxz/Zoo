using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Zologico.interfaces;

namespace Zologico.classes
{
    public class TratadorMamifero : Tratador, ICuidavel
    {
        public TratadorMamifero(string nome) : base (nome)
        {

        }

        public void Cuidar()
        {
            Console.WriteLine($"{NomeTradator} está cuidando");
        }
    }
}
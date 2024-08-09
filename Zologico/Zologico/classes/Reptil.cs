using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zologico.classes
{
    public class Reptil : Animal
    {
        public string TipoEscama { get; set; }

        public Reptil(string nome, int idade, string tipoEscama) : base(nome, idade)
        {
            TipoEscama = tipoEscama;
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} faz som de reptil");
        }
    }
}

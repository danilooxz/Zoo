using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zologico.interfaces;

namespace Zologico.classes
{
   public class ZologicoClass
    {
        private List<Animal> anamais = new List<Animal>();
        private List<Tratador> tratadores = new List<Tratador>();

        public void AdiconarAnimal(Animal animal)
        {
            anamais.Add(animal);
            Console.WriteLine($"{animal.Nome} foi adicionado");
        }
    
        public void ListarAnimais()
        {
            if (anamais.Count > 0)
            {
                Console.WriteLine("Animais no Zologico");
                foreach (Animal animal in anamais)
                {
                    animal.EmitirSom();
                    Console.WriteLine($"Nome:{animal.Nome}, Idade:{animal.Idade}");
                }
            }
            else
            {
                Console.WriteLine("A lista está vazia");
            }
        }
    
        public void AlimentarAnimais()
        {
            Console.WriteLine("Alimentando os animais...");
            foreach (Animal animal in anamais)
            {
                if (animal is IAlimentavel alimentavel)
                {
                    alimentavel.Alimentar();
                }
            }
        }

        public void CuidarAnimais()
        {
            Console.WriteLine("Cuidando dos animais...");
            foreach (Animal animal in anamais)
            {
                if (animal is ICuidavel cuidavel)
                {
                    cuidavel.Cuidar();
                }
            }
        }

        public void AdicionarTratadoresMamifero(Tratador tratador)
        {
            tratadores.Add(tratador);
            Console.WriteLine($"{tratador.NomeTradator} foi adicionado");
        }

        public void AdicionarTratadoresAve(Tratador tratador)
        {
            tratadores.Add(tratador);
            Console.WriteLine($"{tratador.NomeTradator} foi adicionado");
        }

        public void ListarTratadores()
        {
            if (tratadores.Count > 0)
            {
                Console.WriteLine("Tratadores no Zologico");
                foreach (Tratador tratador in tratadores)
                {
                    Console.WriteLine($"Nome do tratador: {tratador.NomeTradator}");
                }

            }
            else
            {
                Console.WriteLine("A lista de tratadores está vazia");
            }
        
        }
    }
}

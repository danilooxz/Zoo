using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zologico.classes;

namespace Zologico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZologicoClass zologico = new ZologicoClass();

            while (true)
            {
                Console.WriteLine("Selecione a Opção");
                Console.WriteLine("1. Adicionar Mamífero");
                Console.WriteLine("2. Adicionar Ave");
                Console.WriteLine("3. Adicionar Reptil");
                Console.WriteLine("4. Listar Animais");
                Console.WriteLine("5. Alimentar Animais");
                Console.WriteLine("6. Cuidar Animais");
                Console.WriteLine("7. Adicionar Tratador de Mamíferos");
                Console.WriteLine("8. Adicionar Tratador de Aves");
                Console.WriteLine("9. Listar Tratadores");
                Console.WriteLine("10. Sair");
                string opcao = Console.ReadLine();

                if (opcao == "10")
                {
                    break;
                }

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o nome do mamífero: ");
                        string nomeMamifero = Console.ReadLine();

                        Console.WriteLine("Digite a idade do mamífero: ");
                        int idadeMamifero = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o pelo do aninal: ");
                        string tipoPelo = Console.ReadLine();

                        Mamifero mamifero = new Mamifero(nomeMamifero, idadeMamifero, tipoPelo);
            
                        zologico.AdiconarAnimal(mamifero);
                        break;

                    case "2":
                        Console.WriteLine("Digite o nome do ave: ");
                        string nomeAve = Console.ReadLine();

                        Console.WriteLine("Digite a idade do ave: ");
                        int idadeAve = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a envergadura da ave: ");
                        double envergadura = double.Parse (Console.ReadLine());

                        Ave ave = new Ave(nomeAve,idadeAve, envergadura);

                        zologico.AdiconarAnimal(ave);
                        break;

                    case "3":
                        Console.WriteLine("Digite o nome do reptil: ");
                        string nomeReptil = Console.ReadLine();

                        Console.WriteLine("Digite a idade do reptil: ");
                        int idadeReptil = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o tipo de escama do reptil: ");
                        string tipoEscama = Console.ReadLine();

                        Reptil reptil = new Reptil(nomeReptil, idadeReptil, tipoEscama);

                        zologico.AdiconarAnimal(reptil);
                        break;

                    case "4":
                        zologico.ListarAnimais();
                        break;
                    
                    case "5":
                        zologico.AlimentarAnimais();
                        break;

                    case "6":
                        zologico.CuidarAnimais();
                        break;

                    case "7":
                        Console.WriteLine("Digite o nome do tratador de mamífero");
                        string nomeTratadorM = Console.ReadLine();

                        TratadorMamifero tratadorMamifero = new TratadorMamifero(nomeTratadorM);
                        zologico.AdicionarTratadoresMamifero(tratadorMamifero);
                        break;

                    case "8":
                        Console.WriteLine("Digite o nome do tratador de mamífero");
                        string nomeTratadorA = Console.ReadLine();

                        TratadorAves tratadorAves = new TratadorAves(nomeTratadorA);
                        zologico.AdicionarTratadoresAve(tratadorAves);
                        break;

                    case "9":
                        zologico.ListarTratadores();
                        break;

                    default:
                        Console.WriteLine("Opção Desconhecidade");
                        break;

                }
            }
        }
    }
}

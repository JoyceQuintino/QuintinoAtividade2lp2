using Atividade2EFCoreClassLib.Entidades;
using System;
using System.Linq;

namespace Atividade2EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context()){

                /*Banco b = new Banco(){Nome = "Bradesco"};
                context.Add(b);
                context.SaveChanges();

                Agencia bradesco = new Agencia() {Numero = 778559, BancoId = b.Id};
                context.Add(bradesco);
                context.SaveChanges();*/

                while (true)
                {
                    Console.WriteLine("Informe a opção:\n");
                    Console.WriteLine("0 - Sair do sistema\n");
                    Console.WriteLine("1 - Adicionar cliente\n");
                    Console.WriteLine("2 - Listar clientes\n");
                    Console.WriteLine("3 - Alterar cliente\n");
                    Console.WriteLine("4 - Deletar cliente\n");

                    int num = Convert.ToInt32(Console.ReadLine());

                    if(num == 0)
                        break;
                    else
                    {
                        switch (num)
                        {
                            case 1: 
                                Console.WriteLine("Informe o nome do cliente:");
                                var nome1 = Console.ReadLine();
                                var cliente = new Cliente() { Nome = nome1};
                                context.Add(cliente);
                                context.SaveChanges();
                                break;
                            case 2: 
                                var clientes = context.Set<Cliente>();
                                foreach (var c in clientes)
                                    Console.WriteLine($"Cliente:\t{c.Nome}");
                                    break;
                            case 3:
                                Console.WriteLine("Informe o nome:");
                                var nomeAtual = Console.ReadLine();
                                Console.WriteLine("Informe o novo nome:");
                                var nomeNovo = Console.ReadLine();
                                var buscar1 = context.Set<Cliente>().First(c => c.Nome.Equals(nomeAtual));
                                buscar1.Nome = nomeNovo;
                                context.SaveChanges();
                                break;
                            case 4:
                                Console.WriteLine("Informe o nome:");
                                var nome2 = Console.ReadLine();
                                var buscar2 = context.Set<Cliente>().First(cl => cl.Nome == nome2);
                                context.Remove(buscar2);
                                context.SaveChanges();
                                break;
                            default:
                                Console.WriteLine("Opção inválida");
                                break;
                        }
                    }
                }
            }
        }
    }
}

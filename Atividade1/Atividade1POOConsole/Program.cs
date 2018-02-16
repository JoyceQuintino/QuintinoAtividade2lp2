Console.WriteLine("Digite suas informações.");

            int num = Convert.ToInt32(Console.ReadLine("Informe a opção: "));
            Console.WriteLine("1 - Inserir\n 2 - Listar\n 3 - Deletar\n 4 - Alterar\n");

            switch (num)
            {
                case 1: 
                    Console.WriteLine("Cliente: ");
                        Console.WriteLine("Informe o titular: ");
                        var Cliente = new Cliente() {Nome = Convert.ToString(Console.Read())}
                        Cliente.ClientesSolicitacoes.Add(new ClienteSolicitacao(){ClienteId = Cliente.Id, });
                        
                case 2:

                default: Console.WriteLine("Opção inválida !");
            }

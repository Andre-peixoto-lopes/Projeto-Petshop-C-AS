using projeto_AS;
using System;
using System.Collections.Generic;

namespace ca_siscar_parte1_menuinterativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            int opcsub = 0;
            List<Especies> bancoEspecies = new List<Especies>();
            List<Animal> bancoAnimais = new List<Animal>(); // Lista para armazenar animais
            List<Cliente> bancoClientes = new List<Cliente>(); // Lista para armazenar clientes

            while (opc != 9)
            {
                Console.WriteLine("\n");
                Console.WriteLine("SISPET");
                Console.WriteLine("1. Especies");
                Console.WriteLine("2. Animais");
                Console.WriteLine("3. Clientes");
                Console.WriteLine("9. Sair");
                Console.Write("Digite a opcao: ");
                opc = int.Parse(Console.ReadLine());

                if (opc == 1)
                {
                    opcsub = 0;
                    while (opcsub != 19)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("ESPECIES");
                        Console.WriteLine("10. Inserir");
                        Console.WriteLine("11. Alterar");
                        Console.WriteLine("12. Excluir");
                        Console.WriteLine("13. Pesquisar");
                        Console.WriteLine("19. SAIR");
                        Console.Write("Digite a opcao: ");
                        opcsub = int.Parse(Console.ReadLine());

                        switch (opcsub)
                        {
                            case 10:
                                Especies especie = new Especies();
                                Console.Write("Digite o código da espécie: ");
                                especie.id = int.Parse(Console.ReadLine());
                                Console.Write("Digite o nome da espécie: ");
                                especie.nome = Console.ReadLine();
                                bancoEspecies.Add(especie);
                                Console.WriteLine("Especie inserida com sucesso!");
                                break;

                            case 11:
                                Console.Write("Digite o ID da espécie a ser alterada: ");
                                int idAlterar = int.Parse(Console.ReadLine());
                                Especies especieParaAlterar = bancoEspecies.Find(e => e.id == idAlterar);
                                if (especieParaAlterar != null)
                                {
                                    Console.Write("Digite o novo nome da espécie: ");
                                    especieParaAlterar.nome = Console.ReadLine();
                                    Console.WriteLine("Especie alterada com sucesso!");
                                }
                                else
                                {
                                    Console.WriteLine("Especie não encontrada!");
                                }
                                break;

                            case 12:
                                Console.Write("Digite o ID da espécie a ser excluída: ");
                                int idExcluir = int.Parse(Console.ReadLine());
                                Especies especieParaExcluir = bancoEspecies.Find(e => e.id == idExcluir);
                                if (especieParaExcluir != null)
                                {
                                    bancoEspecies.Remove(especieParaExcluir);
                                    Console.WriteLine("Especie excluída com sucesso!");
                                }
                                else
                                {
                                    Console.WriteLine("Especie não encontrada!");
                                }
                                break;

                            case 13:
                                Console.Write("Digite o nome ou parte do nome da espécie a ser pesquisada: ");
                                string nomePesquisa = Console.ReadLine();
                                List<Especies> especiesEncontradas = bancoEspecies.FindAll(e => e.nome.Contains(nomePesquisa, StringComparison.OrdinalIgnoreCase));
                                if (especiesEncontradas.Count > 0)
                                {
                                    Console.WriteLine("Espécies encontradas:");
                                    foreach (var esp in especiesEncontradas)
                                    {
                                        Console.WriteLine(esp.ToString());
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Nenhuma espécie encontrada com esse nome!");
                                }
                                break;

                            case 19:
                                Console.WriteLine("Saindo do menu de espécies...");
                                break;

                            default:
                                Console.WriteLine("Opção inválida! Tente novamente.");
                                break;
                        }
                    }
                }
                else if (opc == 2)
                {
                    opcsub = 0;

                    while (opcsub != 29)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("ANIMAIS");
                        Console.WriteLine("20. Inserir");
                        Console.WriteLine("21. Alterar");
                        Console.WriteLine("22. Excluir");
                        Console.WriteLine("23. Pesquisar");
                        Console.WriteLine("29. SAIR");
                        Console.Write("Digite a opcao: ");
                        opcsub = int.Parse(Console.ReadLine());

                        switch (opcsub)
                        {
                            case 20:
                                // Inserir novo animal
                                Animal animal = new Animal();
                                Console.Write("Digite o ID do animal: ");
                                animal.Id = int.Parse(Console.ReadLine());
                                Console.Write("Digite o nome do animal: ");
                                animal.Nome = Console.ReadLine();
                                Console.Write("Digite o apelido do animal: ");
                                animal.Apelido = Console.ReadLine();
                                Console.Write("Digite o ano de nascimento do animal: ");
                                animal.Nascimento = int.Parse(Console.ReadLine());
                                Console.Write("Digite observações sobre o animal: ");
                                animal.Observacoes = Console.ReadLine();
                                bancoAnimais.Add(animal);
                                Console.WriteLine("Animal inserido com sucesso!");
                                break;

                            case 21:
                                // Alterar animal existente
                                Console.Write("Digite o ID do animal a ser alterado: ");
                                int idAlterarAnimal = int.Parse(Console.ReadLine());
                                Animal animalParaAlterar = bancoAnimais.Find(a => a.Id == idAlterarAnimal);
                                if (animalParaAlterar != null)
                                {
                                    Console.Write("Digite o novo nome do animal: ");
                                    animalParaAlterar.Nome = Console.ReadLine();
                                    Console.Write("Digite o novo apelido do animal: ");
                                    animalParaAlterar.Apelido = Console.ReadLine();
                                    Console.Write("Digite o novo ano de nascimento do animal: ");
                                    animalParaAlterar.Nascimento = int.Parse(Console.ReadLine());
                                    Console.Write("Digite novas observações sobre o animal: ");
                                    animalParaAlterar.Observacoes = Console.ReadLine();
                                    Console.WriteLine("Animal alterado com sucesso!");
                                }
                                else
                                {
                                    Console.WriteLine("Animal não encontrado!");
                                }
                                break;

                            case 22:
                                // Excluir animal existente
                                Console.Write("Digite o ID do animal a ser excluído: ");
                                int idExcluirAnimal = int.Parse(Console.ReadLine());
                                Animal animalParaExcluir = bancoAnimais.Find(a => a.Id == idExcluirAnimal);
                                if (animalParaExcluir != null)
                                {
                                    bancoAnimais.Remove(animalParaExcluir);
                                    Console.WriteLine("Animal excluído com sucesso!");
                                }
                                else
                                {
                                    Console.WriteLine("Animal não encontrado!");
                                }
                                break;

                            case 23:
                                // Pesquisar animal
                                Console.Write("Digite o nome ou parte do nome do animal a ser pesquisado: ");
                                string nomePesquisaAnimal = Console.ReadLine();
                                List<Animal> animaisEncontrados = bancoAnimais.FindAll(a => a.Nome.Contains(nomePesquisaAnimal, StringComparison.OrdinalIgnoreCase));
                                if (animaisEncontrados.Count > 0)
                                {
                                    Console.WriteLine("Animais encontrados:");
                                    foreach (var anm in animaisEncontrados)
                                    {
                                        Console.WriteLine(anm.ToString());
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Nenhum animal encontrado com esse nome!");
                                }
                                break;

                            case 29:
                                Console.WriteLine("Saindo do menu de animais...");
                                break;

                            default:
                                Console.WriteLine("Opção inválida! Tente novamente.");
                                break;
                        }
                    }
                }
                else if (opc == 3)
                {
                    // Implementação da opção 3: Gerenciar Clientes
                    opcsub = 0;
                    while (opcsub != 39)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("CLIENTES");
                        Console.WriteLine("30. Inserir");
                        Console.WriteLine("31. Alterar");
                        Console.WriteLine("32. Excluir");
                        Console.WriteLine("33. Pesquisar");
                        Console.WriteLine("39. SAIR");
                        Console.Write("Digite a opcao: ");
                        opcsub = int.Parse(Console.ReadLine());

                        switch (opcsub)
                        {
                            case 30:
                                // Inserir novo cliente
                                Cliente cliente = new Cliente();
                                Console.Write("Digite o ID do cliente: ");
                                cliente.Id = int.Parse(Console.ReadLine());
                                Console.Write("Digite o nome do cliente: ");
                                cliente.Nome = Console.ReadLine();
                                Console.Write("Digite o CPF do cliente: ");
                                cliente.Cpf = Console.ReadLine();
                                Console.Write("Digite o email do cliente: ");
                                cliente.Email = Console.ReadLine();
                                cliente.DataRegistro = DateTime.Now; // Define a data de registro como a data atual
                                bancoClientes.Add(cliente);
                                Console.WriteLine("Cliente inserido com sucesso!");
                                break;

                            case 31:
                                // Alterar cliente existente
                                Console.Write("Digite o ID do cliente a ser alterado: ");
                                int idAlterarCliente = int.Parse(Console.ReadLine());
                                Cliente clienteParaAlterar = bancoClientes.Find(c => c.Id == idAlterarCliente);
                                if (clienteParaAlterar != null)
                                {
                                    Console.Write("Digite o novo nome do cliente: ");
                                    clienteParaAlterar.Nome = Console.ReadLine();
                                    Console.Write("Digite o novo CPF do cliente: ");
                                    clienteParaAlterar.Cpf = Console.ReadLine();
                                    Console.Write("Digite o novo email do cliente: ");
                                    clienteParaAlterar.Email = Console.ReadLine();
                                    Console.WriteLine("Cliente alterado com sucesso!");
                                }
                                else
                                {
                                    Console.WriteLine("Cliente não encontrado!");
                                }
                                break;

                            case 32:
                                // Excluir cliente existente
                                Console.Write("Digite o ID do cliente a ser excluído: ");
                                int idExcluirCliente = int.Parse(Console.ReadLine());
                                Cliente clienteParaExcluir = bancoClientes.Find(c => c.Id == idExcluirCliente);
                                if (clienteParaExcluir != null)
                                {
                                    bancoClientes.Remove(clienteParaExcluir);
                                    Console.WriteLine("Cliente excluído com sucesso!");
                                }
                                else
                                {
                                    Console.WriteLine("Cliente não encontrado!");
                                }
                                break;

                            case 33:
                                // Pesquisar cliente
                                Console.Write("Digite o nome ou parte do nome do cliente a ser pesquisado: ");
                                string nomePesquisaCliente = Console.ReadLine();
                                List<Cliente> clientesEncontrados = bancoClientes.FindAll(c => c.Nome.Contains(nomePesquisaCliente, StringComparison.OrdinalIgnoreCase));
                                if (clientesEncontrados.Count > 0)
                                {
                                    Console.WriteLine("Clientes encontrados:");
                                    foreach (var cli in clientesEncontrados)
                                    {
                                        Console.WriteLine(cli.ToString());
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Nenhum cliente encontrado com esse nome!");
                                }
                                break;

                            case 39:
                                Console.WriteLine("Saindo do menu de clientes...");
                                break;

                            default:
                                Console.WriteLine("Opção inválida! Tente novamente.");
                                break;
                        }
                    }
                }
                else if (opc == 9)
                {
                    Console.WriteLine("Saindo do programa...");
                }
                else
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                }
            }
        }
    }
}

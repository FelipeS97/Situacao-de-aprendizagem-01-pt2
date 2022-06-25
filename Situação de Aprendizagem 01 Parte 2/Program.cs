using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Situação_de_Aprendizagem_01_Parte_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String cliente, nome1, nome2, endereço1, sexo1, endereço2, sexo2, rg1, rg2, cpf1, cpf2;
            int idade1, idade2;
            double telefone1, telefone2;
            
            nome1 = ("Marcelo Rodrigues");
            endereço1 = ("Av Capitao Claro nº 199, bairro Centro");
            sexo1 = ("Masculino");
            idade1 = 20;
            telefone1 = 8633212640;
            cpf1 = "085.168.034-38";
            rg1 = "3.999.756";


            nome2 = ("Augusto Marques");
            endereço2 = ("Av Pinheiro Machado nº 33, bairro Rodoviaria");
            sexo2 = ("Masculino");
            idade2 = 25;
            telefone2 = 8633227891;
            cpf2 = "092.014.120-57";
            rg2 = "3.750.861";

            //Fazer outro cliente para ter alternativas no programa
            //Cadastro da empresa para saber os dados do cliente que entrou em contato
            //O programa irá perguntar qual cliente o usuário deseja saber os dados
            //O usuário digitará o nome do cliente, e o programa retornará os dados do cliente


            Console.WriteLine("Cadastro de Clientes\r\n");

                Console.WriteLine("Qual o nome do cliente?");
                   cliente = (Console.ReadLine());

                    if (cliente == "Marcelo Rodrigues")
                        {
                            Console.WriteLine("Os dados do cliente são: \r\n"+
                                              "Nome: "+ nome1
                                              + "\r\n"+
                                              "Endereço: "+ endereço1
                                              + "\r\n"+
                                              "Sexo: "+ sexo1
                                              + "\r\n"+
                                              "Idade: "+ idade1
                                              + "\r\n"+
                                              "Telefone: "+ telefone1
                                              + "\r\n"+
                                              "CPF: "+ cpf1
                                              + "\r\n"+
                                              "RG: "+ rg1
                                              + "\r\n");
                        }
                    else
                        {
                            Console.WriteLine("Os dados do cliente são: \r\n"+
                                              "Nome: "+ nome2
                                              + "\r\n"+
                                              "Endereço: "+ endereço2
                                              + "\r\n"+
                                              "Sexo: "+ sexo2
                                              + "\r\n"+
                                              "Idade: "+ idade2
                                              + "\r\n"+
                                              "Telefone: "+ telefone2
                                              + "\r\n"+
                                              "CPF: "+ cpf2
                                              + "\r\n" + "RG: " +rg2 + "\r\n");
                        }

            Console.WriteLine("Pressione ENTER para sair...");
            Console.Read();
        }
    }
}

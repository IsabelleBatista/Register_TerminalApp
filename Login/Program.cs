using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Program
    {
        struct DadosCadastrais_Struct
        {
            public string Nome;
            public string Sobrenome;
            public UInt32 Idade;
        };
        static void Main(string[] args)
        {
            List<DadosCadastrais_Struct> ListaCadastro = new List<DadosCadastrais_Struct>();
            string opcao;
            do
            {
                Console.WriteLine("Digite C para cadastrar, ou S para sair");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (opcao == "c")
                {
                    //cadastrar novo usuário
                    DadosCadastrais_Struct dadosCadastrais;

                    Console.WriteLine("Digite seu nome: ");
                    dadosCadastrais.Nome = Console.ReadLine();

                    Console.WriteLine("Digite seu sobrenome: ");
                    dadosCadastrais.Sobrenome = Console.ReadLine();

                    Console.WriteLine("Digite sua idade: ");
                    dadosCadastrais.Idade = Convert.ToUInt32(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("Cadastro feito com sucesso!");

                    ListaCadastro.Add(dadosCadastrais);
                    Console.Clear();
                }
                else if (opcao == "s")
                {
                    //sair  
                    Console.WriteLine("Encerrando a aplicação...");
                    Console.ReadKey();
                }
                else
                {
                    //opção desconhecida
                    Console.WriteLine("Opção desconhecida");
                }
            } while (opcao != "s");
            Console.WriteLine("Pessione qualquer tecla para sair");
            Console.ReadKey(true);

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            Console.Title = "URNA - Cria sua Eleição";

            do
            {
                showMenuPrincipal();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        break;
                    case 1:
                        menuLegislativa();
                        break;
                    case 2:
                        showMenuLegislativa();
                        break;
                }

                //votacaoLegislativo.criarEleicao();
            }
            while (opcao != 0);
        }

        static void showMenuPrincipal()
        {
            Console.Write("Selecione um ambito eleitoral: ");

            Console.WriteLine("\n\n" + "1 - Legislativa" + "\n2 - Executiva" + "\n0 - Sair");
        }

        static void menuLegislativa()
        {
            Console.WriteLine(
                "\n\nEleições: \n" + 
                "1 - Deputado Estadual" + 
                "\n2 - Deputado Federal" + 
                "\n3 - Vereador Municipal" +
                "\n0 - Sair");
            
            switch (int.Parse(Console.ReadLine()))
            {
                case 0:
                    break;
                case 1:
                    deputadoEstadual();
                    break;
                case 2:
                    showMenuLegislativa();
                    break;
                case 3:
                    showMenuLegislativa();
                    break;
            }
        }

        static void deputadoEstadual ()
        {
            IEleicao eleicao_dep_estadual = null;
            int opcao;

            do
            {
                Console.WriteLine(
                "\n\nEleições: \n" +
                "1 - Criar eleição" +
                "\n2 - Cadastrar Candidato" +
                "\n3 - Iniciar Votação" +
                "\n0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        break;
                    case 1:
                        eleicao_dep_estadual = new Dep_Estadual(5);
                        break;
                    case 2:
                        if (eleicao_dep_estadual != null)
                        {
                            eleicao_dep_estadual.criaCandidato(
                            new Candidato(
                                new Partido("Caralhos", "CRL", 13),
                                1234,
                                "Valdemir",
                                "12315465487",
                                "8798as7d879a"));
                        }
                        else
                        {
                            Console.WriteLine("É necessário criar uma eleição para cadastrar candidatos");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Iniciar a votação encerra a criação de novos candidatos, continuar? S - N");
                        if (Console.ReadLine().Equals('S'))
                            iniciarVotacao(eleicao_dep_estadual);
                        break;
                }
            }
            while (opcao != 0);
        }

        static void iniciarVotacao(IEleicao eleicao)
        {
            int numero;
            string cpf, nome, titulo;

            Console.WriteLine("Nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("CPF: ");
            cpf = Console.ReadLine();

            Console.WriteLine("Titulo: ");
            titulo = Console.ReadLine();

            Console.WriteLine("Número do candidato: ");
            numero = int.Parse(Console.ReadLine());

            eleicao.cadastrarVoto();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static EleicaoDAO eleicaoController = new EleicaoDAO();
        static void Main(string[] args)
        {
            int opcao;

            Console.Title = "URNA - Cria sua Eleição";

            do
            {
                Console.WriteLine("Cadastrar Eleição");
                Console.WriteLine("1 - Legislativo \n2 - Executivo");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        break;
                    case 1:
                        cadastrarEleicao(new List<string>() { 
                            "Deputado Estadual", 
                            "Deputado Federal", 
                            "Vereador Municipal" 
                        });
                        break;
                    case 2:
                        cadastrarEleicao(new List<string>() { 
                            "Deputado Estadual", 
                            "Deputado Federal", 
                            "Vereador Municipal" 
                        });
                        break;
                }

                //votacaoLegislativo.criarEleicao();
            }
            while (opcao != 0);
        }

        static void cadastrarEleicao(List<string> cargos, string ambito)
        {
            int opcao;
            do
            {
                Console.WriteLine("Cadastrar Eleição " + ambito);
                for (int i = 0; i < cargos.Count(); i++)
                {
                    Console.WriteLine(i + " - " + cargos[i]);
                }   
                opcao = int.Parse(Console.ReadLine());
                
                if(opcao != 0)
                    string tipo_cargo = cargos[opcao];
                else
                    break;

                if (!tipo_cargo.Equals(""))
                {
                    gerenciaEleicao(eleicaoController.criarEleicao(tipo_cargo, "Legislativo"));
                }
            }
            while (opcao != 0);
        }

        static void gerenciaEleicao(Eleicao eleicao)
        {
            int opcao;
            do
            {
                Console.WriteLine("Cadastrar Eleição Legislativa");
                Console.WriteLine("Sempre que for cadastrar um candidato digite 1");
                Console.WriteLine("se deseja sair basta digitar 0\n\n");
                Console.WriteLine("1 - Cadastrar candidato\n2 - Votar\n0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Nome do partido: ");
                        string nmPartido = Console.ReadLine();
                        Console.WriteLine("Sigla: ");
                        string sigla = Console.ReadLine();
                        Console.WriteLine("Número Partido: ");
                        int numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("Número do Candidato: ");
                        int numCandidato = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nome do Candidato: ");
                        string nomeCandidato = Console.ReadLine();
                        Console.WriteLine("CPF: ");
                        string cpf = Console.ReadLine();
                        Console.WriteLine("Titulo de eleitor: ");
                        string titulo = Console.ReadLine();

                        eleicaoController.cadastrarCandidato(
                            eleicao,
                            new Candidato(
                                new Partido(nmPartido, sigla, numero),
                                numCandidato,
                                nomeCandidato,
                                cpf,
                                titulo));
                        break;
                    case 2:
                        Console.WriteLine("Iniciar a votação inibe a criação de novos candidatos, Continuar? 1 - sim / 0 - nao");
                        int escolha = int.Parse(Console.ReadLine());
                        
                        if(escolha == 1)
                            votacao(eleicao);
                        break;
                }
            }
            while (opcao != 0);
        }

        static void votacao(Eleicao eleicao)
        {
            int opcao;
            do
            {
                Console.WriteLine("1 - Votar \n0 - Finalizar votação");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Nome Eleitor: ");
                        string nomeEleitor = Console.ReadLine();
                        Console.WriteLine("CPF: ");
                        string cpf = Console.ReadLine();
                        Console.WriteLine("Titulo de Eleitor: ");
                        string titulo = Console.ReadLine();
                        Console.WriteLine("Numero Candidato: ");
                        int numeroCandidato = int.Parse(Console.ReadLine());

                        eleicaoController.votar(eleicao, new Eleitor(nomeEleitor, cpf, titulo), numeroCandidato);
                        break;
                }
            }
            while (opcao != 0);
        }
    }
}

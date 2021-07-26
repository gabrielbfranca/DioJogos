using System;

namespace DioJogos
{
    class Program
    {
        static JogosRepositorio repositorio = new JogosRepositorio();
		static SystemRepositorio repositorioS = new SystemRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarJogos();
						break;
					case "2":
						InserirJogos();
						break;
					case "3":
						AtualizarJogos();
						break;
					case "4":
						ExcluirJogo();
						break;
					case "5":
						VisualizarJogo();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}
            
        }
        private static void ExcluirJogo()
		{
			Console.Write("Digite o id da série: ");
			int indiceJogo = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceJogo);
			repositorioS.ExcluiS(indiceJogo);
		}

        private static void VisualizarJogo()
		{
			Console.Write("Digite o id da série: ");
			int indiceJogo = int.Parse(Console.ReadLine());

			var jogos = repositorio.RetornaPorId(indiceJogo);
			var sistema = repositorioS.RetornaPorIdS(indiceJogo);

			Console.WriteLine(jogos);
			Console.WriteLine(sistema);
		}

        private static void AtualizarJogos()
		{
			Console.Write("Digite o id da série: ");
			int indiceJogo = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Jogos atualizaJogo = new Jogos(id: indiceJogo,
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Atualiza(indiceJogo, atualizaJogo);

			Console.WriteLine("Digite o requisitos mínimos para o jogo rodar");
			Console.Write("Digite os requisitos mínimos para a CPU funcionar: ");
			string entradaCPU = Console.ReadLine();

			Console.Write("Digite o GB da mémoria: ");
			int entradaMemoriaGB = int.Parse(Console.ReadLine());

			Console.Write("Digite a GPU: ");
			string entradaGPU = Console.ReadLine();

			Console.Write("Digite o armazenamento mínimo: ");
			string entradaArmazenamento = Console.ReadLine();
			SystemRequirements novoRequisito = new SystemRequirements(
										id: indiceJogo,
										CPU: entradaCPU,
										MemoriaGb: entradaMemoriaGB,
										GPU: entradaGPU,
										Armazenamento: entradaArmazenamento);							
			repositorioS.AtualizaS(indiceJogo, novoRequisito);

		}
        private static void ListarJogos()
		{
			Console.WriteLine("Listar jogos");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhum jogo cadastrado.");
				return;
			}

			foreach (var Jogos in lista)
			{
                var excluido = Jogos.retornaExcluido();
				// var excluidoS 
                
				Console.WriteLine("#ID {0}: - {1} {2}", Jogos.retornaId(), Jogos.retornaTitulo(), (excluido ? "*Excluído*" : ""));
			}
			
		}

        private static void InserirJogos()
		{
			Console.WriteLine("Inserir nova série");

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Jogos novoJogo = new Jogos(id: repositorio.ProximoId(),
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Insere(novoJogo);
			Console.WriteLine("insira os requisitos mínimos necessário para o jogo rodar: ");
			//System requirements
			Console.Write("Digite os requisitos mínimos para a CPU funcionar: ");
			string entradaCPU = Console.ReadLine();

			Console.Write("Digite o GB da mémoria: ");
			int entradaMemoriaGB = int.Parse(Console.ReadLine());

			Console.Write("Digite a GPU: ");
			string entradaGPU = Console.ReadLine();

			Console.Write("Digite o armazenamento mínimo: ");
			string entradaArmazenamento = Console.ReadLine();
			SystemRequirements novoRequisito = new SystemRequirements(
										id: repositorio.ProximoId(),
										CPU: entradaCPU,
										MemoriaGb: entradaMemoriaGB,
										GPU: entradaGPU,
										Armazenamento: entradaArmazenamento);							
			repositorioS.InsereS(novoRequisito);
		}

        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("DIO Séries a seu dispor!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar Jogos");
			Console.WriteLine("2- Inserir nova jogo");
			Console.WriteLine("3- Atualizar jogo");
			Console.WriteLine("4- Excluir jogo");
			Console.WriteLine("5- Visualizar jogo");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
    }
}

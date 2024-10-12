// Screen Sound
string mensagemDeBoasVindas = "Boas Vindas ao Sceen Sound";
// List<string> listaDasBandas = new List<string>();
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

void exibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
}

void exibirOpcoesDoMenu()
{
    exibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a media de uma banda");
    Console.WriteLine("Digite 9 para sair");

    Console.Write("\nDigite a sua escolha: ");
    int opcao = Console.ReadLine()!;
    switch (opcao)
    {
        case 1: registrarBandas(); break;
        case 2: mostrarBandasRegistradas(); break;
        case 3: avaliarUmaBanda(); break;
        case 4: exibirMedia(); break;
        case 9: Console.WriteLine("Tchau Tchau! :)"); break;
        default: Console.WriteLine($"Opcao {opcao} nao e valida"); break;
    }
}

void exibirTitulo(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.Clear();
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void registrarBandas()
{
    exibirTitulo("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A Banda {nomeDaBanda} foi registrada com sucesso");
    Thread.sleep(2000);
    Console.Clear();
    exibirOpcoesDoMenu();
}

void mostrarBandasRegistradas()
{
    exibirTitulo("Exibindo todas as bandas");
    for(int indice = 0; indice < bandasRegistradas.Keys; indice++)
    {
        Console.WriteLine($"Banda: {listaDasBandas[indice]}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    exibirOpcoesDoMenu();
}

void avaliarUmaBanda()
{
    exibirTitulo("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if(bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\na nota {nota} para {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
        exibirOpcoesDoMenu();
    } else 
    {
        Console.WriteLine($"A banda {nomeDaBanda} nao existe, ou nao foi registrada");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        exibirOpcoesDoMenu();
    }
}

void exibirMedia()
{
    exibirTitulo("Exibindo a media de uma banda");
    Console.Write("Insira o nome da banda que deseja ver a media: ");
    string nomeDaBanda = Console.ReadLine()!;
     if(bandasRegistradas.ContainsKey(nomeDaBanda))
     {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA media da banda {nomeDaBanda} esta sendo de {notasDaBanda.Average()} atualmente!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        exibirOpcoesDoMenu();
     } else 
     {
        Console.Write($"A banda {nomeDaBanda} nao existe, digite qualquer coisa para voltar: ");
        Console.ReadKey();
        Console.Clear();
        exibirOpcoesDoMenu();
     }
}

exibirOpcoesDoMenu();
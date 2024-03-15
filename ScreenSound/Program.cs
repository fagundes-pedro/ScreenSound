using ScreenSound.Menus;
using ScreenSound.Modelos;

Banda linkinPark = new("Linkin Park");
linkinPark.AdicionarNota(new Avaliacao(10));
linkinPark.AdicionarNota(new Avaliacao(10));
linkinPark.AdicionarNota(new Avaliacao(9));
linkinPark.AdicionarAlbum(new Album("Meteora"));

Banda theBeatles = new("The Beatles");
theBeatles.AdicionarNota(new Avaliacao(10));
theBeatles.AdicionarNota(new Avaliacao(9));
theBeatles.AdicionarNota(new Avaliacao(8));
theBeatles.AdicionarAlbum(new Album("White Album"));

Dictionary<string, Banda> bandasRegistradas = new()
{
    { linkinPark.Nome, linkinPark },
    { theBeatles.Nome, theBeatles }
};
Dictionary<int, Menu> opcoes = new()
{
    { 1, new MenuRegistrarBanda() },
    { 2, new MenuRegistrarAlbum() },
    { 3, new MenuMostrarBandas() },
    { 4, new MenuAvaliarBanda() },
    { 5, new MenuAvaliarAlbum() },
    { 6, new MenuExibirDetalhes() },
    { 7, new MenuNumeroDeAlbuns() },
    { -1, new MenuSair() }
};
void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para avaliar um álbum");
    Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite 7 para exibir o número de álbuns registrados");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuExibido = opcoes[opcaoEscolhidaNumerica];
        menuExibido.Executar(bandasRegistradas);
        if (opcaoEscolhidaNumerica > 0) { ExibirOpcoesDoMenu(); }
    }
    else
    {
        Console.WriteLine("Opção inválida");
        ExibirOpcoesDoMenu();
    }
}
ExibirOpcoesDoMenu();
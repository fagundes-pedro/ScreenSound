using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuNumeroDeAlbuns : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Álbuns Registrados");
        Console.WriteLine($"Total de álbuns registrados na plataforma: {Album.ContadorDeObjetos}");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
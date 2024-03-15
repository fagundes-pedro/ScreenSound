using OpenAI_API;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda novaBanda = new(nomeDaBanda);
        bandasRegistradas.Add(novaBanda.Nome, novaBanda);
        var client = new OpenAIAPI("My Key");

        var chat = client.Chat.CreateConversation();

        chat.AppendSystemMessage($"Resuma a banda {nomeDaBanda} em 1 parágrafo curto.");

        novaBanda.Resumo = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
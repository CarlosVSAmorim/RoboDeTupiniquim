Console.WriteLine("Bem-vindo ao sistema de controle do Robô Tupiniquim.");
Console.WriteLine("Digite o tamanho do grid retangular. Exemplo de entrada: 5 5");
string[] dimensoes = Console.ReadLine().Split(' ');
int maxX = int.Parse(dimensoes[0]);
int maxY = int.Parse(dimensoes[1]);

int numeroRobo = 1;

while (true)
{
    Console.WriteLine($"\nRobô {numeroRobo} - Informe a posição inicial no formato 'X Y D' (exemplo: 1 2 N).");
    Console.WriteLine("Deixe em branco e pressione Enter para encerrar o programa.");

    string linha = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(linha))
    {
        Console.WriteLine("\nEncerrando execução. Todos os robôs foram processados.");
        break;
    }

    string[] posicao = linha.Split(' ');
    int x = int.Parse(posicao[0]);
    int y = int.Parse(posicao[1]);
    char direcao = char.Parse(posicao[2].ToUpper());

    Console.WriteLine("Agora digite a sequência de comandos para o robô (apenas letras E, D e M).");
    Console.WriteLine("Exemplo: EMEMEMEMM");
    string comandos = Console.ReadLine().ToUpper();

    Robo robo = new(x, y, direcao, maxX, maxY);

    Console.WriteLine("Executando os comandos informados...");
    robo.ExecutarComandos(comandos);

    Console.WriteLine($"Resultado final do Robô {numeroRobo}: {robo}");
    numeroRobo++;
}

Console.WriteLine("\nExecução finalizada com sucesso.");
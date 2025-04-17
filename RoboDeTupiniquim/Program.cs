Console.WriteLine("Bem-vindo ao sistema de controle do Robô Tupiniquim.");
Console.WriteLine("Digite o tamanho do grid retangular. Exemplo de entrada: 5 5");
string[] dimensoes = Console.ReadLine().Split(' ');
int maxX = int.Parse(dimensoes[0]);
int maxY = int.Parse(dimensoes[1]);

int numeroRobo = 1;
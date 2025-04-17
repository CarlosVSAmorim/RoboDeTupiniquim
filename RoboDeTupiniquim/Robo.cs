using System;
using System.Collections.Generic;

public class Robo
{
    private static readonly char[] Direcoes = { 'N', 'L', 'S', 'O' };
    private static readonly Dictionary<char, (int dx, int dy)> Movimentos = new()
    {
        {'N', (0, 1)},
        {'L', (1, 0)},
        {'S', (0, -1)},
        {'O', (-1, 0)}
    };

    public int X { get; private set; }
    public int Y { get; private set; }
    public char Direcao { get; private set; }
    private int MaxX, MaxY;

    public Robo(int x, int y, char direcao, int maxX, int maxY)
    {
        X = x;
        Y = y;
        Direcao = direcao;
        MaxX = maxX;
        MaxY = maxY;
    }

    public void ExecutarComandos(string comandos)
    {
        foreach (char comando in comandos)
        {
            switch (comando)
            {
                case 'E':
                    VirarEsquerda();
                    break;
                case 'D':
                    VirarDireita();
                    break;
                case 'M':
                    Mover();
                    break;
            }
        }
    }

    private void VirarEsquerda()
    {
        int idx = Array.IndexOf(Direcoes, Direcao);
        Direcao = Direcoes[(idx + 3) % 4];
    }

    private void VirarDireita()
    {
        int idx = Array.IndexOf(Direcoes, Direcao);
        Direcao = Direcoes[(idx + 1) % 4];
    }

    private void Mover()
    {
        var (dx, dy) = Movimentos[Direcao];
        int novoX = X + dx;
        int novoY = Y + dy;

        if (novoX >= 0 && novoX <= MaxX && novoY >= 0 && novoY <= MaxY)
        {
            X = novoX;
            Y = novoY;
        }
    }

    public override string ToString()
    {
        return $"{X} {Y} {Direcao}";
    }
}
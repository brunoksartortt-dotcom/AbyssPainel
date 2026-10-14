using System.ComponentModel;

string nomeServidor = "Valheim Principal";
int quantidadeJogador = 9;
int capacidadeMax = 10;
int jogadoresEntrando = 1;
bool servidorAtivo = true;
bool podeEntrar = PodeEntrar(quantidadeJogador, capacidadeMax);

bool PodeEntrar(int jogadores, int capacidade)
{
    return jogadores < capacidade;
}

Console.WriteLine(podeEntrar);

PodeEntrar(quantidadeJogador, capacidadeMax);   
Console.WriteLine("Quantidade de jogadores:\n");
string? qtJogador = Console.ReadLine();
bool conversaoValidaJogador = int.TryParse(qtJogador, out int quantidadeDigitada);

while(!conversaoValidaJogador || quantidadeDigitada < 0)
{
    if(!conversaoValidaJogador)
    {
            Console.WriteLine("A conversão falhou: Dados inválidos.\nInsira a informação corretamente:\n");
            qtJogador = Console.ReadLine();
            conversaoValidaJogador = int.TryParse(qtJogador, out quantidadeDigitada);
    }
        else if(quantidadeDigitada < 0)
        {
                Console.WriteLine("A quantidade de jogadores é inválida. Insira a informação corretamente:\n");
                qtJogador = Console.ReadLine();
                conversaoValidaJogador = int.TryParse(qtJogador, out quantidadeDigitada);
        }
}

Console.WriteLine("Digite a capacidade máxima do servidor:\n");
string? capacidadeSv = Console.ReadLine();
bool conversaoValidaCapacidade = int.TryParse(capacidadeSv, out int capacidadeDigitada);

while(!conversaoValidaCapacidade || capacidadeDigitada <= 0)
{
    if(!conversaoValidaCapacidade)
    {
        Console.WriteLine("A conversão falhou: Dados inválidos.\nInsira a informação corretamente:\n");
        capacidadeSv = Console.ReadLine();
        conversaoValidaCapacidade = int.TryParse(capacidadeSv, out capacidadeDigitada);
    }
        else if(capacidadeDigitada <= 0)
        {
            Console.WriteLine("A capacidade máxima do servidor é inválida. Insira a informação corretamente:\n");
            capacidadeSv = Console.ReadLine();
            conversaoValidaCapacidade = int.TryParse(capacidadeSv, out capacidadeDigitada);
        }
        else
        {
            Console.WriteLine("Dados inválidos.\nInsira a informação corretamente:\n");
            capacidadeSv = Console.ReadLine();
            conversaoValidaCapacidade = int.TryParse(capacidadeSv, out capacidadeDigitada);
        }
}

int quantidadeJogador = quantidadeDigitada;
int capacidadeMax = capacidadeDigitada;
bool servidorAtivo = true;
string erro;
bool validarEntrada = ValidarEntrada(servidorAtivo, quantidadeJogador, capacidadeMax, out erro);
bool podeEntrar = validarEntrada;
string status = ObterStatusServidor(servidorAtivo);
string mensagemEntrada = ObterMensagemEntrada(podeEntrar);
//------//------//------//------//------//------//------//------//------//

    string ObterStatusServidor(bool ativo)
    {
        if (!ativo)
        {
            return "Servidor Offline.";
        }

        return "Servidor Online!";
    }

    string ObterMensagemEntrada(bool podeEntrar)
    {
        if (!podeEntrar)
        {
            return "Acesso negado.";
        }

        return "Acesso permitido!";
    }

    void ExibirStatus(string status)
    {
         Console.WriteLine(status);
    }

    bool ValidarEntrada(bool servidor, int jogadores, int capacidade, out string erro)
    {
        if (servidor == false)
        {
            erro = "Servidor Offline...";
            return false;
        }

        if (jogadores < 0)
        {
            erro = "Quantidade de jogadores inválida...";
            return false;
        }

        if (capacidade <= 0)
        {
            erro = "Capacidade máxima de jogadores inválida...";
            return false;
        }

        if (jogadores >= capacidade)
        {
            erro = "Servidor cheio...";
            return false;
        }
            erro = "Entrada válida!";
            return true;

    }

    void ExibirResumoServidor(string status, string mensagemEntrada, string erro)
    {
        ExibirStatus(status);
        ExibirStatus(mensagemEntrada);
        ExibirStatus(erro);
    }

    ExibirResumoServidor(status, mensagemEntrada, erro);
//------//------//------//------//------//------//------//
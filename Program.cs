int quantidadeJogador = 9;
int capacidadeMax = 10;
bool servidorAtivo = true;
bool podeEntrar = PodeEntrar(quantidadeJogador, capacidadeMax, servidorAtivo);
string status = ObterStatusServidor(servidorAtivo);
string mensagemEntrada = ObterMensagemEntrada(podeEntrar);
string validarEntrada = ValidarEntrada(servidorAtivo, quantidadeJogador, capacidadeMax);
//------//------//------//------//------//------//------//------//------

    bool PodeEntrar(int jogadores, int capacidade, bool servidor)
    {
        if (jogadores < 0 || capacidade <= 0 || servidor == false)
        {
            return false;
        }
        
        return jogadores < capacidade;
    }

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

    string ValidarEntrada(bool servidor, int jogadores, int capacidade)
    {
        if (servidor == false)
        {
            return "Servidor Offline.";
        }

        if (jogadores < 0)
        {
            return "Quantidade de jogadores inválidá.";
        }

        if (capacidade <= 0)
        {
            return "Capacidade máxima do servidor inválida";
        }

        if (jogadores >= capacidade)
        {
            return "Servidor cheio.";
        }

            return "Entrada válida!";

    }

    void ExibirResumoServidor(string status, string mensagemEntrada, string validacao)
    {
        ExibirStatus(status);
        ExibirStatus(mensagemEntrada);
        ExibirStatus(validacao);
    }

    ExibirResumoServidor(status, mensagemEntrada, validarEntrada);

//------//------//------//------//------//------//------
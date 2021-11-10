using System;

namespace ExemploApiCatalogoJogos.Exceptions
{
    public class JogoNaoCadastradoException : Exception
    {
        public JogoNaoCadastradoException()
            : base("Este jogo n�o est� cadastrado")
        { }
    }
}
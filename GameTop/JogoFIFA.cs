using GameTop.Interface;

namespace GameTop
{
    public class JogoFIFA 
    {
        private readonly IJogador _jogador;

        public JogoFIFA(IJogador jogador)
        {
            _jogador = jogador;
        }
        public void IniciarJogo() 
        {
            _jogador.Corre();
            _jogador.Chuta();
            _jogador.Passa();
        }
    }
}
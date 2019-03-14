using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador: IJogador
    {
        public readonly string _Nome;
        public Jogador(string nome)
        {
            _Nome = nome;
        }

        public string Corre()
        {
            return $"{_Nome} está correndo.";
        }

        public string Chuta()
        { 
            return $"{_Nome} está chutando.";
        }

        public string Passa()
        {
            return $"{_Nome} está passando.";
        }
    }
}
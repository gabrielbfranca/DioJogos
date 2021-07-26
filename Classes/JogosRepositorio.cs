using System.Collections.Generic;

namespace DioJogos
{
    public class JogosRepositorio : Irepositorio<Jogos>
    {
        private List<Jogos> listaJogo = new List<Jogos>();
        public void Atualiza(int id, Jogos objeto)
        {
            listaJogo[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaJogo[id].Excluir();
        }

        public void Insere(Jogos objeto)
        {
            listaJogo.Add(objeto);
        }

        public List<Jogos> Lista()
        {
            return listaJogo;
        }

        public int ProximoId()
        {
            return listaJogo.Count;
        }

        public Jogos RetornaPorId(int id)
        {
            return listaJogo[id];
        }
    }
}
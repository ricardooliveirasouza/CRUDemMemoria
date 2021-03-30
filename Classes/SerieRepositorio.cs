using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
	public class SerieRepositorio : IRepositorio<Serie>
	{
        private List<Serie> listaSerie = new List<Serie>();
		private static int contador = 0;

		private Serie BuscaId(int id)
		{
			return listaSerie.Find(elemento => elemento.retornaId() == id);
		}

		public void Atualiza(int id, Serie objeto)
		{
			Serie item;

			//listaSerie[id] = objeto;
			item = BuscaId(id);
			if(null != item)
			{
				Exclui(objeto.retornaId());
				Insere(objeto);
			}
		}

		public void Exclui(int id)
		{
			Serie item;

			item = BuscaId(id);
			if(null != item)
			{
				listaSerie.Remove(item);
			}
			//listaSerie[id].Excluir();
		}

		public void Insere(Serie objeto)
		{
			listaSerie.Add(objeto);
		}

		public List<Serie> Lista()
		{
			return listaSerie;
		}

		public int ProximoId()
		{
			return ++contador;
		}

		public Serie RetornaPorId(int id)
		{
			Serie item;

			item = BuscaId(id);
			return item;
			//return listaSerie[id];
		}
	}
}
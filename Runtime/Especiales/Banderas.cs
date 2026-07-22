using System.Collections.Generic;
using Ging1991.Persistencia.Lectores.Directos;

namespace Ging1991.Persistencia {

	public class Banderas {

		private readonly LectorListaCadenas lector;
		private readonly List<string> lista;

		public Banderas(string direccion) {
			lector = new(direccion, Lectores.TipoLector.DINAMICO);
			lista = lector.Leer().valor;
		}

		public void Activar(string clave) {
			if (!lista.Contains(clave))
				lista.Add(clave);
			lector.Guardar(lista);
		}

		public void Desactivar(string clave) {
			if (lista.Contains(clave))
				lista.Remove(clave);
			lector.Guardar(lista);
		}

		public bool EstaActivada(string clave) {
			return lista.Contains(clave);
		}

	}

}
using System;
using System.Collections.Generic;
using Ging1991.Persistencia.Lectores;

namespace Ging1991.Dialogos.Persistencia {

	public class LectorLista<T> : LectorGenerico<LectorLista<T>.DatoBD<T>> {

		public LectorLista(string direccion, TipoLector tipo) : base(direccion, tipo) { }

		public List<T> GetLista() {
			return Leer().lista;
		}


		[Serializable]
		public class DatoBD<K> {

			public List<K> lista;

		}

	}

}
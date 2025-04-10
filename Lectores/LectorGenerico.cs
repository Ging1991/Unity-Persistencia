using UnityEngine;

namespace Ging1991.Persistencia.Lectores {
		
	public abstract class LectorGenerico<T> : LectorJSON {

		private T dato;

		public LectorGenerico(string direccion, Tipo tipo) : base(direccion, tipo) {}

		public T Leer() {
			if (dato == null) {
				if (tipo == Tipo.DINAMICO)
					dato = ConvertidorJSON<T>.Convertir(LeerDesdeStream());
				if (tipo == Tipo.RECURSOS)
					dato = ConvertidorJSON<T>.Convertir(LeerDesdeRecursos(direccion));
			}
			return dato;
		}

		public void DescartarCambios() {
			dato = Leer();
		}

		public void Guardar(T dato) {
			if (tipo == Tipo.DINAMICO)
				GuardarHaciaStream(ConvertidorJSON<T>.Convertir(dato));
			else
				Debug.LogWarning("Un lector de recursos no puede guardar. Use un lector de Stream.");
		}

		public void Guardar() {
			Guardar(dato);
		}

		public void InicializarPorDefecto(T defecto) {
			if (!ExistenDatos()) {
				GuardarHaciaStream(ConvertidorJSON<T>.Convertir(defecto));
			}
		}

	}

}
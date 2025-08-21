using System.IO;
using UnityEngine;

namespace Ging1991.Persistencia.Lectores { 

	public abstract class LectorJSON {

		protected string direccion;
		public enum Tipo { DINAMICO, RECURSOS }
		protected Tipo tipo;

		public LectorJSON(string direccion, Tipo tipo) {
			this.direccion = direccion;
			this.tipo = tipo;
		}

		public bool ExistenDatos() {
			return File.Exists(direccion);
		}

		public void EliminarDatos() {
			File.Delete(direccion);
		}

		protected string LeerDesdeStream() {
			return File.ReadAllText(direccion);
		}

		protected void GuardarHaciaStream(string contenido) {
			File.WriteAllText(direccion, contenido);
		}

		protected string LeerDesdeRecursos(string direccion) {
			TextAsset recurso = (TextAsset) Resources.Load(direccion, typeof(TextAsset));
			return (recurso != null) ? recurso.text : "";
		}

		public void InicializarDesdeRecursos(string direccionRecursos) {
			if (!ExistenDatos())
				GuardarHaciaStream(LeerDesdeRecursos(direccionRecursos));
		}

	}

}
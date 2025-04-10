using System;
using System.IO;

namespace Ging1991.Persistencia.Direcciones {

	public class DireccionRecursos : Direccion {

		public DireccionRecursos(string carpeta, string archivo = "") : base(carpeta, archivo) {}

		public override string Generar() {
			if (archivo == "")
				throw new Exception("No hay un archivo cargado. Use [Direccion.Generar(string archivo)] en su lugar.");
			return $"{carpeta}/{Path.GetFileNameWithoutExtension(archivo)}";
		}

		public override string Generar(string archivo) {
			return $"{carpeta}/{Path.GetFileNameWithoutExtension(archivo)}";
		}

	}

}
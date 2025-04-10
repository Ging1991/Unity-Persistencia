using System;

namespace Ging1991.Persistencia.Direcciones {

	public class DireccionDinamica : Direccion {

		public readonly string CARPETA_RAIZ = "\\TEMPORAL\\";

		public DireccionDinamica(string carpeta, string archivo = "") : base(carpeta, archivo) {
			Carpeta.CrearSiNoExiste(Generar(""));
		}

		public override string Generar() {
			if (archivo == "")
				throw new Exception("No hay un archivo cargado. Use [Direccion.Generar(string archivo)] en su lugar.");
			return $"{Carpeta.GetCarpetaRaizDePlataforma()}{CARPETA_RAIZ}\\{carpeta}\\{archivo}";
		}

		public override string Generar(string archivo) {
			return $"{Carpeta.GetCarpetaRaizDePlataforma()}{CARPETA_RAIZ}\\{carpeta}\\{archivo}";
		}

	}

}
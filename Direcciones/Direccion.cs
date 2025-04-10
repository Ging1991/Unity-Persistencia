namespace Ging1991.Persistencia.Direcciones {

	public abstract class Direccion {

		// VERSION 1 => 10/4/2025
		protected readonly string carpeta;
		protected readonly string archivo;

		public Direccion(string carpeta, string archivo) {
			this.carpeta = carpeta;
			this.archivo = archivo;
		}

		public abstract string Generar();

		public abstract string Generar(string archivo);

	}

}
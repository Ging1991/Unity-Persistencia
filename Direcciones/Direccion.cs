namespace Ging1991.Persistencia.Direcciones {

	public abstract class Direccion {

		// EN PROCESO, USAR VERSION 1
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
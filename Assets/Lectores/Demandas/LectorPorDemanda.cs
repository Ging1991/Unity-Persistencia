using System.Collections.Generic;
using Ging1991.Persistencia.Direcciones;

namespace Ging1991.Persistencia.Lectores.Demandas {

	public abstract class LectorPorDemanda<T> {

		private readonly Dictionary<string, T> mapaDatos;
		private readonly Direccion direccionCarpeta;
		private readonly ILector<T> lectorInterno;

		public LectorPorDemanda(Direccion direccionCarpeta, ILector<T> lectorInterno) {
			this.direccionCarpeta = direccionCarpeta;
			this.lectorInterno = lectorInterno;
			mapaDatos = new Dictionary<string, T>();
		}

		public T Leer(string nombre) {

			if (!mapaDatos.ContainsKey(nombre)) {
				mapaDatos.Add(
					nombre, lectorInterno.Leer(direccionCarpeta.Generar(nombre))
				);
			}

			return mapaDatos[nombre];
		}

	}

}
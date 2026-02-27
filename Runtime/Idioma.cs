using System.Collections.Generic;
using Ging1991.Core.Interfaces;
using Ging1991.Persistencia.Lectores;
using UnityEngine;

namespace Ging1991.Persistencia {

	public class Idioma : IProveedor<string, string> {

		private readonly Dictionary<string, string> datos;

		public Idioma(string direccion) {
			LectorMapa<string, string> lector = new(direccion, TipoLector.RECURSOS);
			datos = lector.LeerMapa();
		}

		public string GetElemento(string clave) {
			if (datos.ContainsKey(clave))
				return datos[clave];
			Debug.LogWarning($"No se encontró la clave: {clave}");
			return clave;
		}


	}

}
using System.Collections.Generic;
using Ging1991.Core.Interfaces;
using Ging1991.Persistencia.Lectores;
using UnityEngine;

namespace Ging1991.Persistencia.Proveedores {

	public class ProveedorTexto : IProveedor<string, string> {

		private readonly Dictionary<string, string> datos;

		public ProveedorTexto(string direccion, TipoLector tipo) {
			LectorMapa<string, string> lector = new(direccion, tipo);
			datos = lector.LeerMapa();
		}

		public void AgregarDatos(string direccion, TipoLector tipo) {
			LectorMapa<string, string> lector = new(direccion, tipo);
			Dictionary<string, string> datosBD = lector.LeerMapa();
			foreach (var clave in datosBD.Keys) {
				datos.Add(clave, datosBD[clave]);
			}
		}

		public string GetElemento(string clave) {
			if (datos.ContainsKey(clave))
				return datos[clave];
			Debug.LogWarning($"No se encontró la clave: {clave}");
			return clave;
		}

	}

}
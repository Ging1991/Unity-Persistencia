using System.Collections.Generic;
using Ging1991.Core.Interfaces;
using Ging1991.Persistencia.Datos;
using Ging1991.Persistencia.Lectores;
using UnityEngine;

namespace Bounds.Persistencia.proveedores {

	public class ProveedorColores : IProveedor<string, Color> {

		private readonly Dictionary<string, Color> datos;

		public ProveedorColores(string direccion, TipoLector tipo) {
			datos = new Dictionary<string, Color>();
			AgregarDatos(direccion, tipo);
		}

		public void AgregarDatos(string direccion, TipoLector tipo) {
			LectorMapa<string, ColorBD> lector = new(direccion, tipo);
			Dictionary<string, ColorBD> datosBD = lector.LeerMapa();
			foreach (var clave in datosBD.Keys) {
				datos.Add(clave, datosBD[clave].GetColor());
			}
		}


		public Color GetElemento(string clave) {
			if (datos.ContainsKey(clave)) {
				return datos[clave];
			}
			Debug.LogWarning($"No se encontró la clave: {clave}");
			return Color.clear;
		}

	}

}
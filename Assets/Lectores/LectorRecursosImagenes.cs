using UnityEngine;

namespace Ging1991.Persistencia.Lectores { 

	public class LectorRecursosImagenes {

		protected string direccion;

		public LectorRecursosImagenes(string direccion) {
			this.direccion = direccion;
		}


		public static Sprite GetImagen(string direccion) {
			return (Sprite) Resources.Load(direccion, typeof(Sprite));
		}


	}

}
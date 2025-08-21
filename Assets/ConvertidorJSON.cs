using UnityEngine;

namespace Ging1991.Persistencia {

	public class ConvertidorJSON<T> {

		public static T Convertir(string  valor) {
			return JsonUtility.FromJson<T>(valor);
		}

		public static string Convertir(T valor) {
			return JsonUtility.ToJson(valor);
		}

	}

}
using System.IO;
using UnityEngine;

namespace Ging1991.Persistencia {

	public abstract class Carpeta : MonoBehaviour {

		public static void CrearSiNoExiste(string direccionCarpeta) {
			if (!Directory.Exists(direccionCarpeta)) {
				Directory.CreateDirectory(direccionCarpeta);
				Debug.Log($"Direccion: La carpeta se ha creado correctamente en {direccionCarpeta}.");
			}
		}

		public static string GetCarpetaRaizDePlataforma() {
			return Application.platform == RuntimePlatform.Android ? Application.persistentDataPath : Application.dataPath;
		}

	}

}
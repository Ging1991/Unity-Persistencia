using System;
using UnityEngine;

namespace Ging1991.Persistencia.Datos {

	[Serializable]
	public class ColorBD {

		public byte r;
		public byte g;
		public byte b;
		public byte a;
		private static readonly int DIVISOR = 255;

		public Color GetColor() {
			return new Color(r / DIVISOR, g / DIVISOR, b / DIVISOR, a / DIVISOR);
		}

	}

}
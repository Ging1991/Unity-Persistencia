using Ging1991.Persistencia.Direcciones;
using UnityEngine;

namespace Ging1991.Persistencia.Lectores.Demandas {

	public class LectorPorDemandaImagen : LectorPorDemanda<Sprite> {

		public LectorPorDemandaImagen(Direccion direccionCarpeta) : base(direccionCarpeta, new LectorImagenes()) {}

        public class LectorImagenes : ILector<Sprite> {
            
			public Sprite Leer(string direccion) {
				return (Sprite) Resources.Load(direccion, typeof(Sprite));
            }

        }

    }

}
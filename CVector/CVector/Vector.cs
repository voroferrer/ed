using System;

namespace CVector
{
	public class Vector
	{
		public static void Sort(int[] v) {
			
		}
		/// <summary>
		/// Obtiene el indice con el valor minimo
		/// </summary>
		/// <returns>The minimum.</returns>
		/// <param name="v">V.</param>
		/// <param name="initialIndex">Initial index.</param>
		public static int IndexMin(int[] v, int initialIndex){
			int indexMin = initialIndex;
			for (int index = initialIndex; index < v.Length; index++)
				if (v [index] < v [initialIndex])
					indexMin = index;
			return indexMin;

		}
		/// <summary>
		/// Intercambia en el vector los elementos de index y otherIndex
		/// </summary>
		/// <param name="v">vector a modificar</param>
		/// <param name="index">Indice del elemento</param>
		/// <param name="otherIndex">Otro indice</param>
		public static void Swap(int[] v, int index, int otherIndex){


		}
	}
}


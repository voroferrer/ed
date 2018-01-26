using System;
using System.Collections.Generic;

namespace CBingo
{
	public class Bombo
	{
		private List<int> bolas = new List<int>();
		public Bombo(){
			for (int bola = 1; bola <= 90; bola++)
				bolas.Add (bola);


		}
		private Random random = new Random();
		public int SacarBola(){
			int indexAleatorio = random.Next (bolas.Count);
			int bola = bolas [indexAleatorio];
			bolas.Remove (bola);
			return bola;
		}
		public bool QuedanBolas(){
			return bolas.Count > 0;
		}


	}
}


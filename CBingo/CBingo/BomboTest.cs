using NUnit.Framework;
using System;
using System.Collections.Generic;
namespace CBingo
{
	[TestFixture]
	public class BomboTest
	{
		[Test]
		public void sacarBola ()
		{
			List<int> bolas = new List<int> ();
			Bombo bombo = new Bombo ();

			for (int contador = 1; contador <= 90; contador++) {
				int bola = bombo.SacarBola ();
				Assert.IsTrue (bola >= 1 && bola <= 90, "El valor no esta entre 1 y 90");
				Assert.IsFalse (bolas.Contains (bola), "bola repetida :" + bola);
				bolas.Add (bola);			
			}

		}

		[Test]
		public void QuedanBolas(){
			Bombo bombo = new Bombo ();

			for (int contador = 1; contador <= 90; contador++) {
				Assert.IsTrue (bombo.QuedanBolas (), "Tras sacar una deben quedar bolas");
				bombo.SacarBola ();
			}	
			Assert.IsFalse (bombo.QuedanBolas (), "No debe quedar ninguna bola");
		}
	}
}


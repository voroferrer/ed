package org.institutoserpis.ed;

import java.util.Random;
import java.util.Scanner;

public class Adivina {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		Random rand = new Random();
		int numero = rand.nextInt(1000) + 1;
		System.out.println("Adivina el numero entre 1 y 1000 :");
		int introducido = scanner.nextInt();
		int intentos = 0;
		while (numero != introducido) {
			if (numero > introducido)
				System.out.println("Incorrecto, el numero introducido es menor que el generado, prueba otra vez :");
			else
				System.out.println("Incorrecto, el numero introducido es mayor que el generado, prueba otra vez :");
			introducido = scanner.nextInt();
			intentos++;

		}
		System.out.println("Correcto");
		System.out.println("Te ha costado : " + intentos + " intentos");
	}

}

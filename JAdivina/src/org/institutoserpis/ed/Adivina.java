package org.institutoserpis.ed;

import java.util.Random;
import java.util.Scanner;

public class Adivina {

	public static void main(String[] args) {
		Scanner scanner = new Scanner (System.in);
		Random rand = new Random ();
		int numero = rand.nextInt(1000);				
		System.out.println("Adivina el numero entre 1/1000");
		String leer= scanner.nextLine();
		int introducido = Integer.parseInt(leer);
		int correcto = 0;
		while (correcto != 1) {
			if (numero != introducido) {
				if (numero > introducido) {
					System.out.println("Incorrecto, el numero introducido es menor que el generado");
					String nuevo= scanner.nextLine();
					introducido = Integer.parseInt(nuevo); 
				}
				else {
					System.out.println("Incorrecto, el numero introducido es mayor que el generado");
					String nuevo= scanner.nextLine();
					introducido = Integer.parseInt(nuevo);
				} 					
			}
			else {
			System.out.println("Correcto");
			correcto = 1;
			}
		}
	}
}

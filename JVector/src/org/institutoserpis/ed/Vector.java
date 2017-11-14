package org.institutoserpis.ed;

import java.util.Scanner;

public class Vector {
	public static void main(String[] args) {
		Scanner tcl = new Scanner(System.in);
		int[] v = new int[] { 9, 15, 7, 12, 6 };
		int num, posicion, min;
		System.out.print("Introduce un numero :");
		num = tcl.nextInt();
		posicion = posicion(v, num);
		if (posicion == (-1))
			System.out.println("El numero no esta en ninguna posición.");
		else
			System.out.println("El numero esta en la posición " + posicion);
		min = min(v);
		posicion = posicion(v, min);
		System.out.println("El numero menor de la serie es " + min + " y esta en la posición " + posicion);

		System.out.print("El array ordenado de menor a mayor es :");
		menorAMayor(v);
	}
	public static int posicion(int[] v, int value) {
		for (int index = 0; index < v.length; index++)
			if (v[index] == value)
				return index;
		return -1;
	}
	public static int min(int[] v) {
		int min = v[0];
		for (int x = 0; x < v.length; x++) {
			if (min > v[x])
				min = v[x];
		}
		return min;
	}
	public static int min(int[] v, int i) {
		int min = v[i];
		for (int x = i; x < v.length; x++) {
			if (min > v[x])
				min = v[x];

		}
		return min;
	}
	public static void menorAMayor(int[] v) {
		for (int i = 0; i < v.length; i++) {
			int min, aux, posicion;
			min = min(v, i);
			aux = v[i];
			posicion = posicion(v, min);
			v[i] = min;
			v[posicion] = aux;
		}
		System.out.println(v[0] + "," + v[1] + "," + v[2] + "," + v[3] + "," + v[4]);
	}
}

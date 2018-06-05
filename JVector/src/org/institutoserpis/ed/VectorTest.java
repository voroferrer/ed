 package org.institutoserpis.ed;

import static org.junit.Assert.*;

import org.junit.Test;

public class VectorTest {

	@Test
	public void Index() {
		int[] v = new int[] {9,15,7,12,6};
		assertEquals(0,Vector.posicion(v,9));
		assertEquals(2,Vector.posicion(v,7));
		assertEquals(4,Vector.posicion(v,6));
		assertEquals(-1,Vector.posicion(v,33));
		
	}
	@Test
	public void IndexEmpty() {
		int[] v = new int[] {};
		assertEquals(-1,Vector.posicion(v,7));
	}
	@Test
	public void min() {
		assertEquals(6,Vector.min(new int[] {9,15,7,12,6}, 0));
		assertEquals(7,Vector.min(new int[] {9,15,7,12,16}, 0));
		assertEquals(9,Vector.min(new int[] {9,15,17,12,16}, 0));
		
	}
	public void binarySearchNotFound(){
		int[] v = new int [] {7,14,21,27,31};
		assertEquals(-1, Vector.binaySearch(v,6));
		assertEquals(-1, Vector.binaySearch(v,10));
		assertEquals(-1, Vector.binaySearch(v,29));
		assertEquals(-1, Vector.binaySearch(v,33));
		assertEquals(-1, Vector.binaySearch(v,16));
		assertEquals(-1, Vector.binaySearch(v,23));
	}
	public void binarySearchFound(){
		int[] v = new int [] {7,14,21,27,31};
		assertEquals(0, Vector.binaySearch(v,7));
		assertEquals(1, Vector.binaySearch(v,14));
		assertEquals(2, Vector.binaySearch(v,21));
		assertEquals(3, Vector.binaySearch(v,27));
		assertEquals(4, Vector.binaySearch(v,33));
		
	}
	public void binarySearchOverflow(){
		int[] v = new int [Integer.MAX_VALUE];
	
	}
}

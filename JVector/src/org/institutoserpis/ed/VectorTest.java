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
}

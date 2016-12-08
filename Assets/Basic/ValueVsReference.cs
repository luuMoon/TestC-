using UnityEngine;
using System.Collections;
using System;
using System.Runtime.InteropServices;

namespace test1
{
	namespace test2
	{
		class AA
		{
		}
		namespace test3
		{
			class B : test1.test2.AA
			{
			}
		}
	}
}


public class ValueVsReference : MonoBehaviour {

	public readonly int rOnly1 = -1 , rOnly2;

	struct Point1
	{
		public int x,y;
	}

	class Point2
	{
		public int x,y;
	}

	struct Point3
	{
		public int a;
		public long b;
		public byte c;
		public int d;
	}

	ValueVsReference()
	{
		rOnly1 = 1;
	}


	void Start () 
	{
		
		//value
		Point1 p1 = new Point1();
		Point1 p2 = p1;
		p1.x = 1;
		p1.y = 2;
		Debug.Log ("<color=yellow>" + p1.x + "</color>");
		Debug.Log (p2.x);

		//reference
		Point2 p3 = new Point2 ();
		Point2 p4 = p3;
		p3.x = 1;
		Debug.Log ("<color=yellow>" + p3.x + "</color>");
		Debug.Log (p4.x);

		//test null
		//error: cant use null for valueType
		//string valueNull = p1 == null;
		p3 = null; 	
		bool referenceNull = p3 == null;
		//Debug.Log ("<color=yellow>" + p3.x + p3.y + "</color>");
		Debug.Log(referenceNull);

		//sizeof valueType
		Point3 p5 = new Point3 ();
		Debug.Log (Marshal.SizeOf (p5));

		//Test Type
		Debug.Log (p1.GetType ());
		Debug.Log (1.GetType ());
		Debug.Log (0xF11.GetType ());
		Debug.Log (1.0.GetType ());

		//value must be Defined
		//int x;
		//Debug.Log (x);

		//rOnly2 = 1;
		Debug.Log ("<color=yellow>" + rOnly1 + "</color>" + rOnly2);
	

	}

}

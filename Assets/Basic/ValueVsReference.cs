using UnityEngine;
using System.Collections;

public class ValueVsReference : MonoBehaviour {

	struct Point1
	{
		public int x,y;
	}

	class Point2
	{
		public int x,y;
	}

	void Start () 
	{
		
		//value
		Point1 p1 = new Point1();
		Point1 p2 = p1;
		p1.x = 1;
		Debug.Log ("<color=yellow>" + p1.x + "</color>");
		Debug.Log (p2.x);

		//reference
		Point2 p3 = new Point2 ();
		Point2 p4 = p3;
		p3.x = 1;
		Debug.Log ("<color=yellow>" + p3.x + "</color>");
		Debug.Log (p4.x);
	}

}

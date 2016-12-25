using UnityEngine;
using System.Collections;

public class mutableValue : MonoBehaviour {
	public struct Mutable
	{
		public int x;
		public int Mutate()
		{
			this.x = this.x + 1;
			return this.x;
		}
	}

	public struct testMutableValue
	{
		public int a;
	}

	public readonly Mutable m = new Mutable();
	// Use this for initialization
	void Start () 
	{
		Mutable testV = new Mutable ();

		//mutableValue test = new mutableValue ();
		//this.m.Mutate ();
		Debug.Log (m.Mutate ());
		Debug.Log (m.Mutate ());
		Debug.Log (m.Mutate ());

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

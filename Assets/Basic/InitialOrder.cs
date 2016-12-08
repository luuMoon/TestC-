using UnityEngine;
using System.Collections;

public class InitialOrder : MonoBehaviour {
	private class testInitial : ScriptableObject
	{
		public int key;
	  	public testInitial()
		{
			key = 1;
		}

		public testInitial(int word) : this()
		{
			Debug.Log(key);
		} 

	}
	
	private string testOrder = "Num1";
	public static string testStaticOrder = "Order1";
	void Awake()
	{
		//test Init Order
		testInitial testInit = new testInitial (2){key = 3};
		Debug.Log (testInit.key);
		/////////
		Debug.Log ("<color=blue>" + this.testOrder + "</color>" + InitialOrder.testStaticOrder);
	}

	// Use this for initialization
	void Start () 
	{
		Debug.Log ("<color=blue>" + this.testOrder + "</color>" + InitialOrder.testStaticOrder);
		InitialOrder.testStaticOrder = "Order3";
		testOrder = "Num3";
		Debug.Log ("<color=blue>" + this.testOrder + "</color>" + InitialOrder.testStaticOrder);
		
	}

	//-------------------------------------------------------------------------------------
	//Constructor can be called in some odd way when inheritance MonoBehaviour
	public InitialOrder()
	{
		Debug.Log ("RuaRuaRua");
		//Debug.Log ("<color=blue>" + this.testOrder + "</color>" + InitialOrder.testStaticOrder);
		//InitialOrder.testStaticOrder = "Order2";
		//testOrder = "Num2";
	}
	~InitialOrder()
	{
		Debug.Log ("RURU");
	}

	//dont call by U3D
	public static void Main()
	{
		InitialOrder.testStaticOrder = "Order4";
	//	Debug.Log ("RuaRuaRua");
		//Debug.Log (InitialOrder.testStaticOrder);
	}
	//-------------------------------------------------------------------------------------

}

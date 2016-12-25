using UnityEngine;
using System.Collections;
using System;

public class Delegate : MonoBehaviour {
	//normal delegate
	public delegate void delegateVoid();
	//static delegate
	public delegate void staticDelegate();
	//generic delegate
	public delegate T genericDelegate<T>(T param);

	public Func<int,int> genericDelegate2;
	// Use this for initialization
	void Start ()
	{
		staticDelegate testStaticDelegate = Delegate.testStaticDelegate;
		testStaticDelegate ();

		genericDelegate2  += testGenericDelegate;
		int result = genericDelegate2 (2);
		Debug.Log (result);
		////test delegate
		//delegateVoid testDelegateVoid += testVoidParam;
		//testDelegateVoid ();
		//target and method
		Debug.Log ("<color=red>" + testStaticDelegate.Target + " " + testStaticDelegate.Method + "</color>");
	}

	public int testGenericDelegate(int param)
	{
		return param * param;
	}

	public static void testStaticDelegate()
	{
		Debug.Log ("<color=blue>" + "test Static Delegate" + "</color>");
	}

	public void testVoidParam()
	{
		Debug.Log ("<color=blue>" + "test One Param Delegate" + "</color>");
	}

}

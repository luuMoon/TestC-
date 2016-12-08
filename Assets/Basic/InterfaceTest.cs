using UnityEngine;
using System.Collections;

public interface ITestUpcast
{
	void testLog1();
}

public interface ITestInterface
{
	void testLogInterface();
}
public class BaseInterface : ITestInterface
{
	public void testLogInterface()
	{
		Debug.Log ("<color=red>" + "Base Interface" + "</color>");
	}
}

public class InherienceInterface : BaseInterface,ITestInterface
{
	public void testLogInterface()
	{
		Debug.Log ("<color=yellow>" + "Inherience Interface" + "</color>");
	}
}


public class TestClass1 : ITestUpcast
{
	public void testLog1()
	{
		Debug.Log ("TestClass1");
	}

	void testLog2()
	{
		Debug.Log ("<color=blue>" + "this is Class1" + "</color>");
	}
}



public abstract class TestNestedClass
{
	private TestNestedClass()
	{

	}
	private sealed class NestedClass1 : TestNestedClass
	{
	}
}


public class InterfaceTest : MonoBehaviour {

	private void testInterface(ITestUpcast t)
	{
		//t.testLog3 ();
		t.testLog1 ();
		if (t is ITestUpcast)
			Debug.Log ("RuaRuaRua");
		if (t is TestClass1)
			Debug.Log ("YES ---- is TestClass1");
		else
			Debug.Log ("<color=red>" + "NO --- is not TestClass1" + "</color>");
	}


	// Use this for initialization
	void Start () {
		//test Interface inherience
		InherienceInterface testInherience = new InherienceInterface ();
		testInherience.testLogInterface ();
		((ITestInterface)testInherience).testLogInterface ();
		((BaseInterface)testInherience).testLogInterface ();

		//TestClass1 test1 = new TestClass1 ();
		//testInterface (test1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

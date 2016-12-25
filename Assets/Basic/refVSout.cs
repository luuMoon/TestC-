using UnityEngine;
using System.Collections;

public class refVSout : MonoBehaviour 
{
	public class ValueClass
	{
		public int mValue;
	}

	public string referenceType = "Before";
	public void valueTransfer(int param1 , ValueClass param2)
	{
		param1 += 10;
		param2.mValue += 10;
	}

	void Start () 
	{
		int testValue = 10;
		ValueClass valueClass = new ValueClass ();
		valueTransfer (testValue, valueClass);
		Debug.Log (testValue + "  " + valueClass.mValue);
	}

}

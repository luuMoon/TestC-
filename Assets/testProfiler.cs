using UnityEngine;
using System.Text;
using System.Collections;

public class testProfiler : MonoBehaviour {
	private StringBuilder testString = new StringBuilder();
	void Update ()
	{
		Profiler.BeginSample ("test ProfilerSample");
		for (int i = 0; i < 1000; i++)
		{
			testString.Append (i);
			if(i == 999)
			{
				Debug.Log(testString);
			}
		}
		Profiler.EndSample ();
	}
}

using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		CountToTen ();
		print (",,,,,,");
		CountToTen ();
		print (",,,,,,,");
	}

	void CountToTen()
	{
		int i = 1;
		while (i <= 10) 
		{
			print (i);
			i++;
				}

		print ("Congrats you counted to ten!");


	}





	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine;
using System;

public class Examples : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void  CurrentTime()
	{
		string greeting;
		int hour = DateTime.Now.Hour;

		if (hour < 12)
			greeting = "Good morning";
		else if (hour < 17)
			greeting = "Good afternoon";
		else
			greeting = "Good evening";

		print (string.Format (" {0}, the current time is {1}. ", greeting, DateTime.Now.ToLongTimeString()));


	}

	public void Date()
	{
		string hello;
		int day = DateTime.Now.Day;

		if (day <= 14)
			hello = "first half of month";
		else if (day == 14)
			hello = "middle of month";
		else
			hello = "last half of month";
			

		print (string.Format ( " {0} , the current date is {1}. " , hello , DateTime.Now.ToLongTimeString()));
	}
}

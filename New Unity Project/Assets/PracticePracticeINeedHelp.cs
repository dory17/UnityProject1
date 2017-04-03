using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PracticePracticeINeedHelp : MonoBehaviour{ 
	
	private string[] Firstnames = {"John" , "Jacob" , "JinglehimerShcmidt" , "Paul" , "Steve" };
	private string[] Colors = {"Red" , "Blue" , "Green" , "Yellow" , "Orange" };
	private int counter = 0;
	public string number;
	public List<string> NumberShop = new List<string>();

	//generates random numbersa nd adds them to a list
	public void Begin()
	{
		NumberShop.Add ("6");
		NumberShop.Add ("9");
		NumberShop.Add ("1");
		NumberShop.Add ("2");
	}

	public void AddNumber()
	{
		if (number != ""){
			{
			if (NumberShop.Contains(number) != true){
				NumberShop.Add (number);
			}
		}
	}
}
	// Use this for initialization
	//created 2 arrays one with names and one with colors and had them scrambled to create a sentence.
	void Start ()
	{
		counter++;
		{
			print (Firstnames [Random.Range (0, Firstnames.Length)] + "'s favorite color popsicle is " + Colors [Random.Range (0, Colors.Length)]);

		}
	}
}

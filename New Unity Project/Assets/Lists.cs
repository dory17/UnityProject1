using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Lists : MonoBehaviour {
	public string animal;
	public List<string> zooRoster = new List<string>();



	// Use this for initialization
	void Start () {
		zooRoster.Add ("monkey");
		zooRoster.Add ("elephant");
		zooRoster.Add ("alligator");
		zooRoster.Add ("lion");
	
		}
	public void AddAnimal()
	{
		if (animal != "") {
			{
				if (zooRoster.Contains (animal) != true) {
					zooRoster.Add (animal);
				}
			}
		}
	}
	public void DeleteAnimal ()

	{
		if (zooRoster.Contains (animal))
			zooRoster.Remove (animal);
	}

	public void ClearList ()
	{
		if (zooRoster.Contains (animal))
			zooRoster.Clear ();
		
		}

	public void PrintAllAnimals()
		{
			
		System.Console.WriteLine(animal);
		}
		
		
}
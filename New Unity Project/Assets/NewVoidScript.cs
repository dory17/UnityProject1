using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NewVoidScript : MonoBehaviour {
	float grade = 0;
	float score = 5;
	private int num1 = 5;
	private int num2 = 2;
	float[] scores = { 98f, 78f, 88f, 94f };


	//Adding 2 Numbers Together to create a sum total 
	void Start () {
		NumberCount (10f , 15f);
		print(NumberCount(NumberCount (5f, 16f), NumberCount(3f, 5f) ) );
	}
	float NumberCount(float grade , float score)
	{
		float sum;
		sum = grade + score;
		return sum;
	}


	//2nd Example

	float Average(float[] scores)
	{
		float sum = 0;
		float mean;

		foreach (float thisScore in scores)
		{
			sum += thisScore;
			}

		mean= sum/scores.Length;
		return mean;
	}
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CalculatorAssigment : MonoBehaviour {
	private int counter = 0;
	public int firstNumber = 1;
	public int secondNumber = 100;
	public int TotalAnswer;
	private int numCounter = 0;
	public string number;
	private float num1 = 1;
	private float num2 = 100;
	public float fallSpeed = 8.0f;
	public int myInt = 1;
	public int myInt1 = 1;
	public int i = 0;
	private int [] num = { 1, 2, 3, 4 ,5 ,6 ,7 ,8 ,9 ,10 , 11, 12, 13 , 14, 15, 16 ,17 ,18, 19, 20};
	private int MyCounter =0;
	// Use this for initialization

	public void Start () {
		//waiting to put something in here
		MyCounter++;

	{
			print (num [Random.Range (0 , num .Length)]);
	}
}

	public void AdditionButton () {
		
		{
			float addition = num1 + num2;
			print ("The answer is " + addition );
		}
}
	public void SubtractionButton () {
		{
			float subtract = num1 - num2;
			print ("The answer is" + subtract);
	}
}

	public void MultiplicationButton () {
		{	
			float multiplication = num1 * num2;
			print ("The answer is " + multiplication);
	}
}

	public void DivisionButton () {
		{
			float divide = num1 / num2;
			print ("The answer is " + divide);
		}
	}


	public void sum1(){
		print (Random.Range (1f , 100f));
	}

	public void sum2 () {
		print (Random.Range (1f, 100f));
		}
		
	void onTriggerEnter(Collider other)
	{
		Destroy (other.gameObject);
	}
	
	/*
	public void Stupidnumber1 (){
		Random.Range (1, 100);
	}

	public void stupidNumber2 (){
		Random.Range (1, 100);
	}
	*/
/*
	 SEVERAL IDEAS___ DONT KNOW IF THEY WILL WORK . . .

public void FallingButton(){
			transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
		}

May need this later

{
	if (Input.GetKeyDown (KeyCode.A))
	GetComponent<Renderer> ().gameObject.
numCounter++;
			firstNumber [Random.Range (0, firstNumber.Length)]; 

}

private static readonly Random getrandom = new Random();
{
	lock(synLock) {
		return getrandom.Next(min, max);
	}
}
*/
}
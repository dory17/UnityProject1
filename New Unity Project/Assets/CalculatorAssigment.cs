using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CalculatorAssigment : MonoBehaviour {
	//private int counter = 0;
	//public int firstNumber = 1;
	//public int secondNumber = 100;
	public int TotalAnswer;
	private int numCounter = 0;
	//public string number;
	public float  num1 = 0;
	public float  num2 = 100;
	//public float fallSpeed = 8.0f;
	public int myInt = 1;
	public int myInt1 = 1;
	//public int i = 0;
	private int [] num = {0 , 1 , 2 ,3 ,4 ,5 , 6 , 7 , 8, 9, 10 , 11, 12 , 13 , 14 , 15 , 16 , 17 , 18 , 19 , 20};
	private int MyCounter =0;
	public InputField numberOne;
	public InputField numberTwo;

	// Use this for initialization

	public void Start () {
		//waiting to put something in here
		MyCounter++;
		{
			//Random (num1);
			//numberOne.text = "The answer is" + subtract;
			print (num [Random.Range (0 , num.Length)]);
	}
}

	public void AdditionButton () {
		
		{
			float addition = float.Parse (numberOne.text) + float.Parse (numberTwo.text);
			print ("The answer is " + addition );
		}
}
	public void SubtractionButton () {
		{
			float subtract = float.Parse (numberOne.text) - float.Parse (numberTwo.text);
			print ("The answer is" + subtract);
	}
}

	public void MultiplicationButton () {
		{	
			float multiplication = float.Parse (numberOne.text) * float.Parse (numberTwo.text);
			print ("The answer is " + multiplication);
	}
}

	public void DivisionButton () {
		{
			float divide = float.Parse (numberOne.text) / float.Parse (numberTwo.text);
			print ("The answer is " + divide);
		}
	}
	public void randomNumberGenerator () {
		MyCounter++;
		print (num [	Random.Range (0 , num .Length)] + " is your target # " );
	}

	/*
	public void sum1(){
		sum1 (Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
	}

	public void sum2 () {
		sum2 (Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
		}
		
*/


	//void onTriggerEnter(Collider other)
	//{
	//	Destroy (other.gameObject);
	//}
	
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

//DONT EVER PUT YOUR WORK DOWN; BE PROUD OF IT
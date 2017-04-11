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
	public List<string> NumberCount = new List<string>();
	public string number;
	private float num1 = 1;
	private float num2 = 100;
	public float fallSpeed = 8.0f;
	public int myInt = 1;
	public int myInt1 = 1;
	// Use this for initialization
	void Start () {
		numCounter++;
		{
			
	}
		Random.Range (num1, num2);
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
		Random.Range (1, 100);
	}

	public void sum2 () {
		Random.Range (1, 100);
	}
}

	/*
		public void FallingButton(){
			transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
		}
}
May need this later

{
	if (Input.GetKeyDown (KeyCode.A))
	GetComponent<Renderer> ().gameObject.
numCounter++;
			firstNumber [Random.Range (0, firstNumber.Length)]; 

}*/

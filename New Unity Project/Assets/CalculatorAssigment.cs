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
	private float num2 = 101;
	public float fallSpeed = 8.0f;
	public int myInt = 1;
	public int myInt1 = 1;
	// Use this for initialization
	void Start () {
		numCounter++;
		{
			
	}
}
	public void AdditionButton () {
		
		{
			float addition = num1 + num2;
			print ("The answer is " + num1 + num2);
		}
	}
	public void SubtractionButton () {
			
			float subtract = num1 - num2;
			print ("The answer is" + num1 - num2);
			
}

	public void MultiplicationButton () {
			
		float multiplication = num1 * num2;
			print ("The answer is " + num1 * num2);
}

	public void DivisionButton () {
		float divide = num1 / num2;
			print ("The answer is " + num1 / num2);
}

	public void Num1 () {
		{
			print (Random.Number);
		}
	}

	public void Num2 () {
		{
			print(Random.Number);
		}
	}

	
		public void FallingButton(){
			transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
		}
}
/*May need this later

{
	if (Input.GetKeyDown (KeyCode.A))
	GetComponent<Renderer> ().gameObject.
numCounter++;
			firstNumber [Random.Range (0, firstNumber.Length)]; 

}
*/
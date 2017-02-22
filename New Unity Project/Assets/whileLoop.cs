using UnityEngine;
using System.Collections;
public class whileLoop : MonoBehaviour {

	private int bottles = 0;
	public int maxBottles = 10;
	private bool gameOn = true;
	private int randomNum;
	private int minVal = -10;
	private int maxVAl = 10;
	private int counter = 0;
	private int MaximValue = 50;
	private int MinimValue = 0;
	public int targetValue = 25;


// use this for initialization

	void Start()
	{
		int guess = 0;
		while (counter < 30) {
			guess = Random.Range (0,50);

			counter++;
			if (guess > 25)
				print ("Attempt " + counter + "; " + guess + " Too high");
			else if (guess < 25)
				print ("Attempt "  + counter + "; " + guess + "Too low");
			else if (guess == 25) {
				print ("Attempt " + counter + "; " + guess + "YOU DID IT!!!");
				break;
			}
		}


	}
		
		
				
			


			/*
		while(true)
		{
		randomNum = Random.Range (minVal, maxVAl);
		if (randomNum > 0)
		{
		maxVAl = randomNum;
		}
		if(randomNum < 0)
		{
		minVal = randomNum;
		}

		counter++;

		print ("Attempt" + counter + ":" + minVal + "-" + maxVAl);

		if(maxVAl == 1 && minVal == -1)
		{
		break;
		}
		*/







		/*while (gameOn) 
		{
			print (bottles + "bottles of root beer on the wall.");
			bottles++;
			if (bottles == maxBottles)
		}

		gameOn = false;
		*/





		/*while(bottles < maxBottles)
			{
			if (bottles % 2 == 0) 
			{
				print (bottles + "bottles of rootbeer on the wall.");

			}
			bottles++;
				
			}
			print ("all done");
			
	
		}
	}
*/
}
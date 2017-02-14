using UnityEngine;
using System.Collections;

public class IfElseStatements : MonoBehaviour {
	private bool awake = false;
	private int time = 19;
	private float grade;
	private int Disney = 1923;
	private bool ValentinesDay = true;
	private float Belle = 17;
	private float Mickey = 1928;
	private bool Stitch = false;


	// Use this for initialization
	void Start () {


		/*since the stitch does not == true, it is going to print out the long phrase about family because
		 * stitch == false, not true. */

		if (Stitch == true) {
			print ("Also Cute And Fluffy!");
		} else {
			print ("Aloha means family, family means nobody gets left behind, or forgotten.");
		}


		//since mickey is not less than 1928, it will print out "It all started with a mouse!"

		if (Mickey < 1928) {
			print ("Walt is creating him.");
		}
		else  {
			print ("It all started with a mouse!");
		}





		/*if its true that Valentines Day is today it will print out the phrase "Bahh hum bug!"
		//If it's false then it will print out "It's just another day peeps"
		*/

		if (ValentinesDay == true) {
			print ("Bahh hum bug!");
		} else {
			print ("It's just anbother day peeps");
		}



		/* depending on how old Belle is the output will be one of the following 4 phrases. But since she
		 * is older than 16 and since she is not younger than 15 it going to print out the phrase "BEAUTY AND 
		 * THE BEAST */

		if (Belle == 16) {
			print ("Who could ever learn to love a BEAST?");
		} else if (Belle < 15) {
			print ("I want adventure in the great wide somewhere");
		} else {
			print ("BEAUTY AND THE BEAST");
		}




		/* Since Disney was founded in 1923 the output is going to be "Disney was Founded" because the
		 * other dates/years are not relevant yet.
		 */

		if (Disney == 1923) {
			print ("Disney was founded");
		} else if (Disney > 1922) {
			print ("Disney was not founded yet");
		} else if (Disney < 1924) {
			print ("Disney magic is being created");
		} else {
			print ("Magic is in the works!");
		}







		//CLASS EXAMPLES	


		if (time < 12) {
			print ("Good morning");
		
		} else if (time == 12) {
			print ("lunch time");
		} 
		else if (time < 18) {
			print ("good afternoon");
		}

		else {
			print ("good evening!");
				}


		//CLASS EXAMPLES

		if (grade > 90) {
			print ("A");
		} 
		else if (grade > 80) {
			print ("B");
		}



		//CLASS EXAMPLES

		if (awake == false) {
			print ("Wake Up!");
			awake = true;
		
		}

		else {
			print ("Go to Sleep");
		}



	
	}
		

}

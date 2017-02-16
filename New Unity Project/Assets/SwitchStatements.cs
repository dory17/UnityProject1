using UnityEngine;
using System.Collections;

public class SwitchStatements : MonoBehaviour {
	private int time = 10;
	private string animal = "alligator";
	private string phrase;
	private bool exists = true;
	private int Moana = 16;
	private string princesses = "Cinderella";
	private string quote;
	private bool prince = true;
	public int ages = 21;
	private string NFL = "RAVENS";
	private bool football = false;
	private int LJ = 19;

	// Use this for initialization
	void Start () {
		//MY WORK AND EXAMPLES//


		switch (LJ) {
		case 12:
			print ("What a youngin'");
			break;
		case 16:
			print ("I can drive");
			break;
		case 23:
			print ("Im Old!");
			break;
		case 19:
			print ("Hello");
			break;
		default:
			print ("I'm like the crypt keeper!");
			break;

		}



		//NFL EXAMPLE
		/* I don't understand the bool concept. I feel like I'm doin what you did in your example involving the bool
		 * but it is not working out how I want it to. Either Im missing a step or i just don't get it.
		 * The rest of the code works fine with the switch statement, but I'm struggling with the bool thing.
		 */
		switch (NFL) {
		case "Giants":
			print ("Giants suck!");
			break;
		case "Patriots":
			print ("Popped the football a few superbowls ago!");
			break;
		case "RAVENS":
			print ("Join the Flock! CCCAAWWWW!!");
			break;
		default:
			football = false;
			break;
		}
		//I don't get this lower part, what am I doing wrong?
		if (football == false) {

			print (NFL);
		} else {
			print ("Football is false");
		}



		//AGES EXAMPLE 

		switch (ages) {
		case 18:
			print ("I can move out now!");
			break;
		case 19:
			print ("I won't grow up!");
			break;
		case 21:
			print ("I can buy firearms! woohoo!!");
			break;
		default:
			print ("I have Peter Pan syndrome");
			break;
		}
			
	
		//MY EXAMPLE 


		switch (Moana) {
		case 15:
			print ("Stay on the ground now!!!");
			break;
		case 20:
			print ("Your people will need a chief and there you are");
			break;
		case 13:
			print ("I wanna see");
			break;
		default :
			print ("The Sea It Calls Me!");
			break;

			/*since Moana is not equal to any of the ages listed in the 'cases' then it will print out "The
			 * Sea It Calls Me!" BUT if I replace the number 15 in the first case to 16, then it would print out 
			 * "Stay on the ground now!!!"
			 */


		}


		//DISNEY PRINCESSES
		/* I first had Cinderella as the princess "string" but that didn't print out anything because Cinderella 
		 * was not in a 'case', so it print out the word Cinderella as a default. Then I switched
		 * Belle's name with Cinderella and the output was "I want so much more than they've got 
		 * planned"
		 * I don't understand how to get those quotes inside of ".". I couldn't figure it out
		 * or I didn't understand it very well.
		 */

		switch (princesses) {
		case "Belle":
			quote = "I want so much more than they've got planned!";
			break;
		case "Mulan":
			quote = "Let's get down to buisness, to defeat the Huns!";
			break;
		case "Elsa":
			quote = "Let It Go!!!";
			break;
		case "Pocahontas":
			quote = "Paint With all the Colors of the Wind";
			break;
		default:
			prince = true;
			break;
		}

		//I DON'T UNDERSTAND HOW YOU DID THE ANIMAL THING, AND GOT TWHAT THEY 'SAY' IN QUOTATION MARKS.

		if (prince == true) {
			print (princesses + quote);
				
				}

				
		else 
		{
			print (princesses + "If you wear a dress and have an animal sidekick, you area princess.");
	
		}






		//EXAMPLE ZOO CODE
		switch(animal) {
		case "giraffe":
			phrase = "Wheezy neighbaaah";
			break;
		case "penguin":
			phrase = "Morgan Freeman";
			break;
		case "lion":
			phrase = "roar";
			break;
		case "fox":
			phrase = "fdlkfhalkdfhdanf";
			break;
		case "alligator":
			phrase = "Lets make music together";
			break;
		default:
			exists = false;
			break;

		
		}
		if (exists == true) {
			
			print ("A" + animal + "says" + phrase + "\".");
		} else {
			print (animal + "does not exists.");
		}






		//CLASS EXAMPLE
		//create a switch statement for time of day
		switch (time) {
		case 9:
			print ("Good morning!");
			print ("Its mildly cold outside.");	
			break;
		case 12:
			print ("lunch time");
			break;
		case 18:
			print ("time to go home.");
			break;
		default:
			print ("get back to work!");
			break;
		
		}
	}

	}

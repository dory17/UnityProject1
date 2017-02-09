using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {
	private float A = 3.0f;
	private int B = 3;
	private string name = "Hope";
	private bool awake = false; 
	private string name2 = "Moana2";
	private float demigod = 7;
	private int heihei = 1;
	private float moana = 5;
	private bool asleep = true;
	private int ocean = 6;
	private int underworld = 67;
	private float crab = 67;
	private string Tamatoa = "Drab little crab once";


	 
	/* 
	 ==
	 !=
	 <
	 >
	 <=
	 >=
	 */


	// Use this for initialization
	void Start () {

		if (asleep != false) {
			print ("Ive been staring at the edge of the water. . .");
		}

		/*Since Tamatoa is not equal to "Crabby" then the computer is going to spit out the phrase "Never been
		quite as shiny*/

		if (Tamatoa != "Crabby") {
			print ("Never be quite as shiny!");
		}



		if (underworld >= crab) {
			print ("I'm too shiny!"); 
		}


		//Why isnt this working?
		//Nevermind I figured it out! Yes!!
		/* since name2 isn't equal to "Water" then its going to print out the real name which is 
		 * "Moana2" */

		if (name2 != "Water") {
			print (name2);
		}

		if (moana < ocean) {
			print ("daughter of the village chief");
				}
		
		if (demigod >= ocean) {
			print ("Your Welcome!");
		}


		if (demigod > heihei) {
			print ("eat you for dinner");
		}

		if (moana >= heihei) {
			print ("I AM MOANA!!!");
		}

		if (name2 != "Moana") {
			print ("Pua");
		}

		if (asleep = true) {
			print ("Lava Monster");
		}




		//examples. . . . .

		if(A == B){
		print ("A is equal to B");
		}
		if (A != B) 
		{
			print ("A is not equal to B");
		}
		if (A < B) {
			print ("A is less than B");
		}
		if (A > B) {
			print ("A is greater than B");
		}
		if (A <= B) {
			print ("A is less/equal to B");
		}
		if (A >= B) {
			print ("A is greater/equal to B");
		}
		if (name != "Austin"){
			print (name);
		}
	
		if (awake != true) {
			print ("WAKE UP!");
		}

	}



}

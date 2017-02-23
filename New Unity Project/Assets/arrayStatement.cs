using UnityEngine;
using System.Collections;

public class arrayStatement : MonoBehaviour {
	private string[] Firstnames = { "John", "Jacob", "JinglehimerSchmidt", "PeterPiper", "Jack" };
	private string[] animals = { "Lion", "Tiger", "Bear", "Horse", "Eagle" };
	private string[] jobs = { "GunSalesman", "Soldier", "DrugDealer", "Cop", "Teacher" };
	private string[] personality = { "Evil", "Sneaky", "Dumb", "OutOfControl", "Dubious" };
	private string[] nationality = { "Italian", "American", "Mexican", "Russian", "Tahitian" };
	private int [] age = { 2 , 10 , 25 , 100 , 96 };
	private string [] appearance = { "Sloppy" , "Clean" , "Grubby" , "Fancy" , "Deadly" };
	private string [] react = {"Shoot guns" , "Throw knives" , "Tantrum Throwing" , "Punch" , "Hug" };
	private string [] phrase = {"Wippersnapers" , "Shenanagins" , "Darn it all" , "One day" , "AhyMiMadre"};
	private string [] character2 = { "JackSparrow" , "Cap.America" , "Bucky" , "CheshireCat" , "Thor"};
	private int counter = 0;

	// Use this for initialization
	void Start () {
		
		counter++;
			

		
		{
			
			print (Firstnames[Random.Range (0 , Firstnames.Length)] + ", " + " was the master of a great castle, and he owned a magical house elf named Creature that obeyed everything he said. " +
				"  " + " Creature was so underappreciated in his work that he brought a" + " " + animals [Random.Range (0 ,animals.Length)] +
				" into his masters room in the middle of the night to eat him." + "  " + " Luckily the master of the house was a " + jobs [Random.Range (0 , jobs.Length)] +
				" and he quickly woke up before the animal could eat him and began to " + react [Random.Range (0 , react.Length)] + " . " + " Creature watched as" +
				" his animal friend fell to the ground and said " + phrase [Random.Range (2 , phrase.Length)] + ", " +
				" as it fled from the room quicker than a jackrabbit during hunting season." + "Creature said a crazy phrase in"
				+ nationality [Random.Range (0, nationality.Length)] + "and angrily stomped around the room as he was confronted by his master." + "  " + " 'Why did you try to have that animal eat me?!' exclaimed Creatures master."
				+ " Creature exclaimed huffily, today was my" + age [4] + "th" + " birthday and you promised to give me a sock!"
				+ " ' Well ' , exclaimed the master, ' if I gave you a sock then you'd be free, and I can't free you just yet. ' " + "  "
				+ " Creature exclaimed, ' WHY NOT?! ' " + " His master replied, ' because " + character2 [Random.Range (0, character2.Length)] + " , your friend , asked if he could give you a sock in my place to help you celebrate."
				+ " Creature was suddenly humbled as his master had not forgotten his birthday/freedom afterall. " + " ' But after your "
				+ personality [Random.Range (0 , personality.Length) ] + "behavior I think I want you gone faster than we had planned!" + "So his master picked up a stray sock and threw it at Creature."
				+ " ' Take your sock and be free you " + appearance [Random.Range (0 , appearance.Length)] + " elf! You may do as you wish!' said the master as he shooed Creature out of his room."
				+ "  " + " Creature began dancing around as he held his little sock in his small bony hands. " + "  "
				+ " ' Creature is a free elf!!! ' " + " And with a snap of his fingers he evaporated and went to visit his friend Dobby at Hogwarts.");

		

		}
	}
}
using UnityEngine;
using System.Collections;

public class VariablesandOperators : MonoBehaviour {
	private float pi = 3.1415f;
	private float radius = 3.536235f;
	private float length = 5;
	private float width = 2;
	private float base1 = 1;
	private float height = 4;

	/* with private floats I am able to enter a value for height=4, and when I need to use that code or value for later
	 * I don't have to enter the number in by hand, all i have to do is type 'height' and the value of 4
	 * should already accompany that term. There is no need for me to enter that value in by hand every time I 
	 * need to use it. */


	// Use this for initialization
	void Start () {
		//Find the diameter of a cirlce
		float diameter = 2 * radius;
		print ("The diameter of the cirlce with radius " + radius +  " is " + diameter);

		/* the float diameter = 2 * radius; is the equation by which I solve the diameter for the circle,
		 * when I print a statement, I am explaining what is going on.
		 * Example: ("The diameter of the circle with radius " + radius + " is " + diameter);
		 * This is stating: the diameter of this circle is going to be radius + diameter.
		 * I get confused on what the " + radius + " is " diameter); means. I have a hard time understanding 
		 * that.*/
	
	//Find circumference of a cirlce
		float circumference = 2 * pi * radius;
		print ("The circumference of the circle with a radius of " + radius + " is " + circumference);

	//Find area of a cirlce
		float area = pi *  radius * radius;
		print ("The area of the circle with radius of " + radius + " is " + area);

	//Find volume of a sphere
		float volume = 4/3 * pi * radius * radius * radius;
		print ("The volume of the sphere with radius of " + radius + " is " + volume);

	//Find perimeter of a rectangle
		float perimeter = 2 * (length * width);
		print ("The perimeter of the rectangle of " + " is " + perimeter);
		/*I don't even know if I did this perimeter of the rectangle correctly
		It came out without errors after I fixed it but I don't know it thats right*/

	//Find areatwo of a rectangle
		float areatwo = width * length;
		print ("The areatwo of the rectangle of" + " is " + areatwo);

	//Find areathree of a triangle
		float areathree = height * base1 / 2;
		print ("The areathree of the trianlge of" + " is " + areathree);

	/*Im still trying to wrap my head around a lot of this but I am trying very hard to understand
	 * Thank you for your patience and your help in explaining computer coding; any advice would be
	 * greatly appreciated*/

	}
	}

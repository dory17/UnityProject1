Variables
(Rotate Variables)

using UnityEngine;
using System.Collections;

//You are adjusting the speed of the X,Y, and Z axis so that they rotate at different speeds
// a float is decimal numbers
// public means that anyone will be able to see and access this version of your coding process
// private means that only you will be able to see the changes and true meanings of your code
public class Rotate : MonoBehaviour {
	public float speed;
	public float rotX = 15;
	public float rotY = 30;
	public float rotZ = 45;

	// Use this for initialization
	void Start () {
		speed = Random.Range (.5f, 2.0f);
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (rotX, rotY, rotZ) * Time.deltaTime * speed);
	}

}




(Variable Move)



using UnityEngine;
using System.Collections;

//when you made the float for horizontal speed, you assigned a specific speed to the horizontal movements of your object in Unity
/* so when you inputted the horizontal and vertical speed within the () of the code, the program automatically understood that horizontal speed = .2f and the same goes along with the vertical speed in the other () of code */

/every time you are finished with a bracket of code you place these {} around the code.
/gameObject means that you are editing or making a code for that object within your game, it is just a name so you can keep track of you coding
	public class Move : MonoBehaviour {
	public float horizontalSpeed = .2f;
	public float verticalSpeed = .2f;


	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			gameObject.transform.Translate (-horizontalSpeed, 0, 0);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			gameObject.transform.Translate (horizontalSpeed, 0, 0);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			gameObject.transform.Translate (0, -verticalSpeed, 0);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			gameObject.transform.Translate (0, verticalSpeed, 0);
		}
	}
	/*Example: if InputGetKey (KeyCode.Delete)) {
	 * gameObject.transform.Translate (vertical speed, 0 , 0);
	 * }
	 * Basically I am telling the computer that if the 'delete' button is pushed down then the vertical motion of the game object will move at the desired speed which I assign it.
	 */

}
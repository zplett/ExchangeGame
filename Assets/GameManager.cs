using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	/**generic management class for all one-off initialization and heavy-lifting stuff**/
	/**Stuff like locking cursor, initializing scene, should go in here**/

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

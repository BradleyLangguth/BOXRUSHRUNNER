using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour {


	void OnCollisionEnter(Collision col) {

		if (col.gameObject.name == "EndPoint")
        {
            Debug.Log("YOU WON");
            
 
            
        }
		
	}
}

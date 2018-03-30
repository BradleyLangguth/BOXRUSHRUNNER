using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour {

    private GameObject uppickedObject;
    private Rigidbody uppickedRigidbody;
    private Vector3 screenPoint;
    private Vector3 offset;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //if(Input.GetKeyDown(KeyCode....
        if (Input.GetMouseButtonDown (1))
        {

            if (uppickedObject == null)
            {
                int layerMask = 1 << 8;
                RaycastHit hitInfo;
                if (Physics.Raycast(transform.position + transform.forward, transform.forward, out hitInfo, Mathf.Infinity, layerMask))
                {
                    print("Pickup");
                    print(hitInfo.transform.name);
                    uppickedObject = hitInfo.collider.gameObject;

                    uppickedObject.transform.parent = transform;

                    uppickedRigidbody = (Rigidbody)uppickedObject.GetComponent(typeof(Rigidbody));
                    //uppickedRigidbody.isKinematic = true;
                }
            }

            else
            {
                print("Let Go");

                //uppickedRigidbody.isKinematic = false;

                uppickedObject.transform.parent = null;
                uppickedObject = null;
                

            }

            
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
static class Globals
{
    public static bool keyonhand = false;
    public static bool D2Open = false;
    public static bool D3Open = false;
}
public class Pickup : MonoBehaviour {

	

    public Transform onHand;

    void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        Globals.keyonhand = true;
        this.transform.position = onHand.transform.position;
        //this.transform.parent = GameObject.Find("FPSControllor").transform;
        this.transform.parent = GameObject.Find("FirstPersonCharacter").transform;
    }

	void OnMouseOver () {
		if (Input.GetMouseButtonDown(1)) {
			this.transform.parent = null;
			Globals.keyonhand = false;
			GetComponent<Rigidbody>().useGravity = true;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warning : MonoBehaviour {
	/*void Start()
	{
		OnGUI ();
	}*/
	public bool onTrigger = false;
	void OnTriggerEnter(Collider other)
	{
		onTrigger = true;
	}
	// Use this for initialization
	void OnTriggerExit(Collider other)
	{
		onTrigger = false;
	}
	void OnGUI()
	{
		if(onTrigger) GUI.Box(new Rect(350, 800, 750, 1080), " What is this?? A zombie??!! Where is this place..!! I need to escape....");
	}

}

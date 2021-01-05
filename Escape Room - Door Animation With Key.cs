using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class D1animController : MonoBehaviour
{
    [SerializeField] private KeyCode DoorKey;
    public Animator anim;
    private bool dooropen = false;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (dooropen == false && Globals.keyonhand == true)
        {
            dooropen = true;
            anim.Play("firstDoorAnimation");
        }
        else if (Input.GetKeyDown(DoorKey))
        {
            dooropen = false;
            anim.Play("D1Close");
        }
    }

    /*void OnMouseDown()
    {
        if (Input.GetKeyDown(DoorKey) && dooropen == false && Globals.keyonhand == true)
        {
            dooropen = true;
            anim.Play("firstDoorAnimation");
        }
        else if (Input.GetKeyDown(DoorKey))
        {
            dooropen = false;
            anim.Play("D1Close");
        }

    }*/
}

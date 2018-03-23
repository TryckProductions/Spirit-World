using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour {

    public bool isDia;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Entity")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (other.GetComponent<EntityScript>().isDialogue == true)
                {
                    isDia = !isDia;
                }
                other.GetComponent<EntityScript>().EntityAction();
            }
        }
    }
}

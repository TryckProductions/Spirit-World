using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicObjPosession : MonoBehaviour {

    public bool isPos;

    GameObject objPosessed;
    public Transform lastPos;

	// Use this for initialization
	void Start()
    {
        isPos = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && isPos == true)
        {

            gameObject.transform.position = lastPos.position;
            isPos = false;

        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "posObj")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                if (isPos == false)
                {
                    objPosessed = other.gameObject;
                    basicPos();
                }
                /*
                else if(isPos == true)
                {
                    gameObject.transform.position = lastPos.position;
                    isPos = false;
                }
                */   
            }
        }
    }

    private void basicPos()
    {
        lastPos = gameObject.transform;
        //animation
        objPosessed.GetComponent<BoxCollider2D>().isTrigger = true;
        gameObject.transform.position = objPosessed.transform.position;
        isPos = true;
    }

}

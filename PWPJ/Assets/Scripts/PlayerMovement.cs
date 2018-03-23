using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float MoveSpd; //Declaring the Move Speed  --Make Private--
    private float HorMulti = 1.3f;  //Increasing the Move Speed When Walking Horizontally

    Rigidbody2D pRgd; //Declaring The Player's Rigidbody Variable
    LevelManager lvlM;
	// Use this for initialization
	void Start () {
        pRgd = gameObject.GetComponent<Rigidbody2D>();  //Attatching the Player's Rigidbody Variable to an ingame Rigidbody
        lvlM = GameObject.Find("LevelManager").GetComponent<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        if (lvlM.MODE == 1)
        {
            pMove();  //Runs the pMove() Function
        }
    }

    private void pMove()
    {
        if (Input.GetKey(KeyCode.W))  //If Pressing W, Move Up
        {

            pRgd.velocity = new Vector2(pRgd.velocity.x, MoveSpd * 1);

        }
        else if (Input.GetKey(KeyCode.S))  //If Pressing S, Move Down
        {
            pRgd.velocity = new Vector2(pRgd.velocity.x, -MoveSpd * 1);
        }

        else pRgd.velocity = new Vector2(pRgd.velocity.x, 0);


        if (Input.GetKey(KeyCode.D))  //If Pressing D, Move Right
        {
            pRgd.velocity = new Vector2((MoveSpd * HorMulti) * 1, pRgd.velocity.y);
        }
        else if (Input.GetKey(KeyCode.A))  //If Pressing A, Move Left
        {
            pRgd.velocity = new Vector2((-MoveSpd * HorMulti) * 1, pRgd.velocity.y);
        }

        else pRgd.velocity = new Vector2(0, pRgd.velocity.y);
    }
}

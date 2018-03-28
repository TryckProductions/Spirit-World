using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float MoveSpd; //Declaring the Move Speed  --Make Private--
    private float HorMulti = 1.3f;  //Increasing the Move Speed When Walking Horizontally
    public bool isUp;
    public bool isDown;
    public bool isRight;
    public bool isLeft;
    public bool isIdle;

    Animator pAnim;
    Rigidbody2D pRgd; //Declaring The Player's Rigidbody Variable
    LevelManager lvlM;
	// Use this for initialization
	void Start () {
        pRgd = gameObject.GetComponent<Rigidbody2D>();  //Attatching the Player's Rigidbody Variable to an ingame Rigidbody
        pAnim = gameObject.GetComponent<Animator>();
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

        pAnim.SetBool("isWalkingUp", isUp);
        pAnim.SetBool("isWalkingDown", isDown);
        pAnim.SetBool("isWalkingRight", isRight);
        pAnim.SetBool("isWalkingLeft", isLeft);
        pAnim.SetBool("isIdle", isIdle);
    }

    private void pMove()
    {
        if (Input.GetKey(KeyCode.W))  //If Pressing W, Move Up
        {

            pRgd.velocity = new Vector2(pRgd.velocity.x, MoveSpd * 1);

            isUp = true;
            isDown = false;
            isRight = false;
            isLeft = false;
            isIdle = false;

        }
        else if (Input.GetKey(KeyCode.S))  //If Pressing S, Move Down
        {
            pRgd.velocity = new Vector2(pRgd.velocity.x, -MoveSpd * 1);

            isUp = false;
            isDown = true;
            isRight = false;
            isLeft = false;
            isIdle = false;
        }

        else
        {
            pRgd.velocity = new Vector2(pRgd.velocity.x, 0);

            isUp = false;
            isDown = false;

            if (isLeft != true && isRight != true)
            {
                isIdle = true;
            }
        }


        if (Input.GetKey(KeyCode.D))  //If Pressing D, Move Right
        {
            pRgd.velocity = new Vector2((MoveSpd * HorMulti) * 1, pRgd.velocity.y);

            isUp = false;
            isDown = false;
            isRight = true;
            isLeft = false;
            isIdle = false;
        }
        else if (Input.GetKey(KeyCode.A))  //If Pressing A, Move Left
        {
            pRgd.velocity = new Vector2((-MoveSpd * HorMulti) * 1, pRgd.velocity.y);

            isUp = false;
            isDown = false;
            isRight = false;
            isLeft = true;
            isIdle = false;
        }

        else
        {
            pRgd.velocity = new Vector2(0, pRgd.velocity.y);

            isRight = false;
            isLeft = false;

            if (isUp != true && isDown != true)
            {
                isIdle = true;
            }
        }
    }
}

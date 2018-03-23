using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public int MODE;
    private bool isCmp;
    PlayerAction pAct;

	// Use this for initialization
	void Start () {
        pAct = GameObject.Find("Player").GetComponent<PlayerAction>();
	}
	
	// Update is called once per frame
	void Update () {
		if(pAct.isDia == true)
        {
            MODE = 2;
            Mode2();
        }
        else
        {
            MODE = 1;
            Mode1();
        }
	}

    private void Mode1()
    {
        GameObject.Find("DiaHolder").transform.GetChild(0).gameObject.SetActive(false);
    }

    private void Mode2()
    {
        GameObject.Find("DiaHolder").transform.GetChild(0).gameObject.SetActive(true);
    }
}

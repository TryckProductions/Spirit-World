using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    public int WeaponSel;
    //Spirit Dash (Double clicking Move Keys) ()
    //1. Crimson Sword ()
    //2. Scarlet Bow ()
    //3. Golden Shield ()
    //4. Emerald Potion ()
    //5. Aquamarine Grapple ()
    //6. Amethyst Gauntlets ()

    // -Q- is a Main Attack
    // -E- is a Heavy Attack;
    private bool lCD;
    private bool rCD;
    public int colorLvl;
    public GameObject CrimSword;
    PlayerMovement playMove;
    Transform pTf;
	// Use this for initialization
	void Start () {
        playMove = gameObject.GetComponent<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
		if(colorLvl > 0 && Input.GetKeyDown(KeyCode.Alpha1))
        {
            WeaponSel = 1;
        }
	}

    private void FixedUpdate()
    {
        pTf = gameObject.transform;

        if(WeaponSel == 1)
        {
            WeaponSword();
        }
    }

    private void WeaponSword()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && lCD == false)
        {
            Instantiate(CrimSword, CrimSword.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1.65f), gameObject.transform.rotation);
            lCD = true;
            StartCoroutine(lCountDown());
        }
    }

    private IEnumerator lCountDown()
    {
        yield return new WaitForSeconds(.05f);
        Destroy(GameObject.Find("CrimSword(Clone)"));
        lCD = false;
    }
}

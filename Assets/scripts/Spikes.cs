using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class Spikes : MonoBehaviour {


    private PlatformerCharacter2D platformerCharacter2D;

    // Use this for initialization
    void Start () {

        platformerCharacter2D = GameObject.FindGameObjectWithTag("Player").GetComponent<PlatformerCharacter2D>();
    }
	
	// Update is called once per frame
	void OnTriggerEnter 2D (Collider2D col) {


        if (col.CompareTag("Player"))
        {
            platformerCharacter2D.Damage(1);

            StartCoroutine (platformerCharacter2D.Knockback (0.02f, 50, platformerCharacter2D.transform.position));
        }

        
	}
}

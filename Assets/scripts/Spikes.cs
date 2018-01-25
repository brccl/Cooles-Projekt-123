using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class Spikes : MonoBehaviour {



    private PlatformerCharacter2D player;

    // Use this for initialization
    void Start () {

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlatformerCharacter2D>();
    }
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D col) { 

        if (col.CompareTag("Player"))
        {
            if (!col.gameObject.GetComponent<PlatformerCharacter2D>().invincibility)

				player.Damage(1);

			StartCoroutine (player.Knockback (0.02f, 50, player.transform.position));     
        }


    }
        
	}


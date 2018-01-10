using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audioplay : MonoBehaviour {

    public AudioClip PickUpSound;

    private void OnTriggerEnter2D(Collider2D other)
    {

        AudioSource.PlayClipAtPoint(PickUpSound, transform.position, 1);
        
    }
}

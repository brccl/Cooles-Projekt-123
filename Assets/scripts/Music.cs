using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour {

    public Slider Laut;
    public Slider Laut1;
    public AudioSource MyAudio;
    public AudioSource FX;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        MyAudio.volume = Laut.value;
        FX.volume = Laut1.value;
        
	}
}

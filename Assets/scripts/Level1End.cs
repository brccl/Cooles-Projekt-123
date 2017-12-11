using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1End : MonoBehaviour {

    [SerializeField] private string NewLevel;
    [SerializeField] public bool Done = false;

 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Hub");
            Done = true;

            
            

        }
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1End : MonoBehaviour {

    [SerializeField] private string NewLevel;
    [SerializeField] static public float EnterValue;
    [SerializeField] public Transform W1;




    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            EnterValue++;
            SceneManager.LoadScene("Hub");
            
            

            
            

        }
    }

    public void Update()
    {
        if (EnterValue >= 1)
        {
            W1.gameObject.SetActive(false);



        }
        else if (EnterValue != 1)
        {

            W1.gameObject.SetActive(true);

        }





    }

}

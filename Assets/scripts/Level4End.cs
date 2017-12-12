using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4End : MonoBehaviour
{

    [SerializeField] private string NewLevel;
    [SerializeField] static public float EnterValue4;
    [SerializeField] public Transform W4;




    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            EnterValue4++;
            SceneManager.LoadScene("Hub");






        }
    }

    public void Update()
    {
        if (EnterValue4 >= 1)
        {
            W4.gameObject.SetActive(false);



        }
        else if (EnterValue4 != 1)
        {

            W4.gameObject.SetActive(true);

        }





    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2End : MonoBehaviour
{

    [SerializeField] private string NewLevel;
    [SerializeField] static public float EnterValue2;
    [SerializeField] public Transform W2;




    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            EnterValue2++;
            SceneManager.LoadScene("Hub");






        }
    }

    public void Update()
    {
        if (EnterValue2 >= 1)
        {
            W2.gameObject.SetActive(false);



        }
        else if (EnterValue2 != 1)
        {

            W2.gameObject.SetActive(true);

        }





    }

}

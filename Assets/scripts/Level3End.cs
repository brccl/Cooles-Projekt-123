using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3End : MonoBehaviour
{

    [SerializeField] private string NewLevel;
    [SerializeField] static public float EnterValue3;
    [SerializeField] public Transform W3;




    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            EnterValue3++;
            SceneManager.LoadScene("Hub");






        }
    }

    public void Update()
    {
        if (EnterValue3 >= 1)
        {
            W3.gameObject.SetActive(false);



        }
        else if (EnterValue3 != 1)
        {

            W3.gameObject.SetActive(true);

        }





    }

}

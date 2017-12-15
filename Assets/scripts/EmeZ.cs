﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmeZ : MonoBehaviour
{

    [SerializeField] public int Wert = 1;
    [SerializeField] public static int EmeZZ = 0;
    [SerializeField] public Transform canvasvoll;
    [SerializeField] public Transform canvasleer;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            Destroy(gameObject);
            canvasvoll.gameObject.SetActive(true);
            canvasleer.gameObject.SetActive(false);
            EmeZZ++;
            



            CoinManager.AddCoins(Wert);


        }

    }


    private void Start()
    {

        

        if (EmeZZ < 1)
        {
            canvasvoll.gameObject.SetActive(false);

        }
        if (EmeZZ >= 1)
        {

            canvasvoll.gameObject.SetActive(true);

        }
    }

    private void Update()
    {




    }
}



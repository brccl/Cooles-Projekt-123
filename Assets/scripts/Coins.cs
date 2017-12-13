using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour {

    [SerializeField] public int Wert = 1;
    [SerializeField] public int CoinZ = 0;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            Destroy(gameObject);


            CoinManager.AddCoins(Wert);
        }

    }


    private void Start()
        {



        }
}

 

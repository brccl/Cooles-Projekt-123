using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour {

    [SerializeField] public int Wert =1;
    [SerializeField] public static int CoinZ = 0;
    [SerializeField] public Transform canvasvoll;
    [SerializeField] public Transform canvasleer;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            Destroy(gameObject);
            canvasvoll.gameObject.SetActive(true);
            canvasleer.gameObject.SetActive(false);
            CoinZ++;
            

            //CoinManager.AddCoins(Wert);


        }

    }


    private void Start()
        {
        if (CoinZ < 1)
        {
            canvasvoll.gameObject.SetActive(false);
            canvasleer.gameObject.SetActive(true);

        }
        if (CoinZ >= 1)
        {

            canvasvoll.gameObject.SetActive(true);
            canvasleer.gameObject.SetActive(false);

        }
    }

    private void Update()
    {
       



    }
}

 

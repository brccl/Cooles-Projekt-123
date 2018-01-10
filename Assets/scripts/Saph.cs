using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saph : MonoBehaviour
{

    [SerializeField] public int Wert = 1;
    [SerializeField] public static int Sap = 0;
    [SerializeField] public Transform canvasvoll;
    [SerializeField] public Transform canvasleer;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            Destroy(gameObject);
            canvasvoll.gameObject.SetActive(true);
            canvasleer.gameObject.SetActive(false);
            Sap++;
            


            


        }

    }


    private void Start()
    {
        if (Sap < 1)
        {
            canvasvoll.gameObject.SetActive(false);
            canvasleer.gameObject.SetActive(true);

        }
        if (Sap >= 1)
        {

            canvasvoll.gameObject.SetActive(true);
            canvasleer.gameObject.SetActive(false);

        }
    }

    private void Update()
    {




    }
}



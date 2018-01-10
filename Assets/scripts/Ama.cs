using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ama : MonoBehaviour
{

    [SerializeField] public int Wert = 1;
    [SerializeField] public static int AAma = 0;
    [SerializeField] public Transform canvasvoll1;
    [SerializeField] public Transform canvasleer2;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            Destroy(gameObject);
            canvasvoll1.gameObject.SetActive(true);
            canvasleer2.gameObject.SetActive(false);
            AAma++;
            





        }

    }


    private void Start()
    {
        if (AAma < 1)
        {
            canvasvoll1.gameObject.SetActive(false);
            canvasleer2.gameObject.SetActive(true);

        }
        if (AAma >= 1)
        {

            canvasvoll1.gameObject.SetActive(true);
            canvasleer2.gameObject.SetActive(false);

        }
    }

    private void Update()
    {




    }
}



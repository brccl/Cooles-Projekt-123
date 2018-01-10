using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmeZ : MonoBehaviour
{

    [SerializeField] public int Wert = 1;
    [SerializeField] public static int EmeZZ = 0;
    [SerializeField] public Transform canvasvoll;
    [SerializeField] public Transform canvasleer;
    public AudioClip CoolerSound;
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(CoolerSound, transform.position, 1);
            Destroy(gameObject);
            canvasvoll.gameObject.SetActive(true);
            canvasleer.gameObject.SetActive(false);
            EmeZZ++;
          
        }

    }


    private void Start()
    {

        

        if (EmeZZ < 1)
        {
            canvasvoll.gameObject.SetActive(false);
            canvasleer.gameObject.SetActive(true);

        }
        if (EmeZZ >= 1)
        {

            canvasvoll.gameObject.SetActive(true);
            canvasleer.gameObject.SetActive(false);

        }
    }

    private void Update()
    {




    }
}



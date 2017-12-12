using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class Level2Enter : MonoBehaviour
{


    [SerializeField] public GameObject PressE;

    private void Start()
    {
        PressE.SetActive(false);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PressE.SetActive(false);
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PressE.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {




                SceneManager.LoadScene("Lv2");

            }
        }
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {


    [SerializeField] public Transform canvas;
    [SerializeField] public Transform canvas1;


    public void Pause()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canvas.gameObject.activeInHierarchy == false)
            {
                canvas.gameObject.SetActive(true);
                canvas1.gameObject.SetActive(false);
                Time.timeScale = 0;

            }
            else
            {
                canvas.gameObject.SetActive(false);
                canvas1.gameObject.SetActive(true);
                Time.timeScale = 1;


            }



        }


    }

    private void Start()
    {
        canvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }


    // Update is called once per frame
    private void Update()
    {
        Pause();

    }
}

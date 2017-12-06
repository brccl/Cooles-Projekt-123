using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {


    public void ToGame()
    {
        SceneManager.LoadScene("Lv1");


    }

    public void ToOptions()
    {

        SceneManager.LoadScene("Option Menu");



    }

    public void ToMainMenu()
    {

        SceneManager.LoadScene("Main Menu");



    }

    public void Quiterino()
    {
        Application.Quit();

    }




}

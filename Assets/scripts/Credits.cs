using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {


    [SerializeField] public Transform C1;
    [SerializeField] public Transform C2;
    [SerializeField] public Transform C3;
    [SerializeField] public Transform C4;
    [SerializeField] public Transform C5;
    [SerializeField] public Transform C6;
    [SerializeField] public Transform C7;


    // Use this for initialization
    void Start () {

        C1.gameObject.SetActive(false);
        C2.gameObject.SetActive(false);
        C3.gameObject.SetActive(false);
        C4.gameObject.SetActive(false);
        C5.gameObject.SetActive(false);
        C6.gameObject.SetActive(false);
        C7.gameObject.SetActive(false);

        StartCoroutine(Example());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Example() { 
    
        yield return new WaitForSecondsRealtime(1);
        C1.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        C2.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        C1.gameObject.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        C3.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        C2.gameObject.SetActive(false);
        yield return new WaitForSecondsRealtime(2);
        C4.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        C3.gameObject.SetActive(false);
        yield return new WaitForSecondsRealtime(2);
        C5.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        C4.gameObject.SetActive(false);
        yield return new WaitForSecondsRealtime(2);
        C6.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        C5.gameObject.SetActive(false);
        yield return new WaitForSecondsRealtime(2);
        C7.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(5);
        SceneManager.LoadScene("Main Menu");




    }


}

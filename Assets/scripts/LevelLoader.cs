using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelLoader : MonoBehaviour {


   [SerializeField] public GameObject LoadingScreen;
   [SerializeField] public Slider slider;
   [SerializeField] public Text progressText;


    public void LoadLevel(int SceneIndex)
    {
        StartCoroutine(LoadSceneAsync(SceneIndex));
        
    }
    
    IEnumerator LoadSceneAsync (int SceneIndex) {


        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneIndex);


        LoadingScreen.SetActive(true);


        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            progressText.text = progress * 100 + "%";

            yield return null;



        }


    }




}

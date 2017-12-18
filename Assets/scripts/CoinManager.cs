using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour {

    public static int coins;
    Text text;
   



    // Use this for initialization
    void Start() {
        text = GetComponent<Text>();
       

        
	}
	
	// Update is called once per frame
	void Update () {
		if (coins < 0)
        {
            coins = 0;
        }
       

        

        text.text = "" + coins;

       
      
	}

    public static void AddCoins(int cnt)
    {
        coins += cnt;
       

       



    }

}

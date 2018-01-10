    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets._2D;


public class PlayerHealthUI : MonoBehaviour
{


    public Sprite[] HeartSprites;
    public Image HeartUI;
    public Image HeartUI1;
    private PlatformerCharacter2D platformerCharacter2D;


    void Start()
    {
        platformerCharacter2D = GameObject.FindGameObjectWithTag("Player").GetComponent<PlatformerCharacter2D>();

    }

    void Update ()
    {
        HeartUI.sprite = HeartSprites [platformerCharacter2D.currentHealth];
        HeartUI1.sprite = HeartSprites[platformerCharacter2D.currentHealth];
    }
}
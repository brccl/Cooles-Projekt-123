﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventroyUi : MonoBehaviour {

    Inventory inventory;

	// Use this for initialization
	void Start () {

        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;
		
	}
	
	// Update is called once per frame
	void Update () {


		
	}
}

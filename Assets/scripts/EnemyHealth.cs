using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	public int currentHealth;
	public int maxHealth = 4;
	private Animator anim;

	// Use this for initialization
	void Start () 
		{
			currentHealth = maxHealth;
		}
	
	// Update is called once per frame
	void Update () 
	{

		if (currentHealth > maxHealth)
		{
			currentHealth = maxHealth;
		}

		if (currentHealth <= 0)
			{
				deSpawn();
			}
	}

	public void Damage(int damage)
	{
		//Deal Damage to Enemy Health
		currentHealth -= damage;
		anim.SetTrigger ("Enemy_Hurt");
	}


	void deSpawn()
	{
		Destroy(gameObject);
	}
}

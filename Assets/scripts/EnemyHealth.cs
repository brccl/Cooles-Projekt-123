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

<<<<<<< HEAD
		hitTimer += Time.deltaTime;

		if(hitTimer > hitTime)



=======
>>>>>>> e9fbce551c22b03dcfe32a459d4bfba74fb2213b
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
<<<<<<< HEAD
		anim.SetTrigger("Enemy_Hurt");
=======
		anim.SetTrigger ("Enemy_Hurt");
>>>>>>> e9fbce551c22b03dcfe32a459d4bfba74fb2213b
	}


	void deSpawn()
	{
		Destroy(gameObject);
	}
}

using UnityEngine;
using System.Collections;

public class playerAttack : MonoBehaviour {

	private bool attacking = false;	
	private float attackTimer = 0;
	public float attackCooldown = 0.3f;
	public Collider2D attackTrigger;
	private Animator anim;

	// Use this for initialization
	void Awake () 
	{
		anim = gameObject.GetComponent<Animator> ();
		attackTrigger.enabled = false;
	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Mouse1) && !attacking)
		{
			attacking = true;
			attackTimer = attackCooldown;
			attackTrigger.enabled = true;
			anim.SetTrigger("Attack");
		}

		if (attacking)
		{
			if (attackTimer > 0)
			{
				attackTimer -= Time.deltaTime;
			}
			else 
			{
				attacking = false;
				attackTrigger.enabled = false;
			}
		}
	}
}


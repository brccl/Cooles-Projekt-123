using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementController : MonoBehaviour {

	public float chargeSpeed;

	Animator enemyAnim;

	public float moveSpeed;
	public float minDistance;
	private float range;



	//Faceing of the enemy 
	public GameObject enemyGraphic;
	bool willFlip = true;
	bool faceRight = false;
	float nextFlipChance = 0f;
	float flipTime = 5f;

	//Patrol Enemy
	Transform other;
	public bool moveRight;
	public Transform wallCheck;
	public LayerMask whatIsWall;
	public float wallCheckRadius;
	private bool hittingWall;
	public float MoveSpeed;
	bool run;
	private bool notAtEdge;
	public Transform edgeCheck;


	//Attack Move Enemy
	public float chargeTime;
	float startChargeTime;
	bool charging;
	Rigidbody2D enemyRB;

	// Use this for initialization
	void Start () {
		enemyAnim = GetComponentInChildren<Animator>();
		enemyRB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	/*	if (Time.time > nextFlipChance) {
			if (Random.Range (0, 10) >= 5)
				flipFacing ();
			nextFlipChance = Time.time + flipTime;
		} */

		/*	transform.LookAt (other.position);
		transform.Rotate (new Vector3 (0, 180, 0), Space.Self);
	} */

		hittingWall = Physics2D.OverlapCircle (wallCheck.position, wallCheckRadius, whatIsWall);
		notAtEdge = Physics2D.OverlapCircle (edgeCheck.position, wallCheckRadius, whatIsWall);


		if (hittingWall || !notAtEdge) {
			moveRight = !moveRight;
			willFlip = true;
			flipFacing ();
		}
		if (moveRight) {
			enemyRB.velocity = new Vector2 (MoveSpeed, enemyRB.velocity.y);
			run = true;
			enemyAnim.SetBool ("Run", run);
		} else {
			enemyRB.velocity = new Vector2 (-MoveSpeed, enemyRB.velocity.y);
			run = true;
			enemyAnim.SetBool ("Run", run);
			
		} 
	}		
			void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			//Enemy Flips Right if Player enters Collider on the Right Side when facing left
			if (!faceRight && other.transform.position.x < transform.position.x) {
				flipFacing ();
			}
			//Enemy Flips Left if Player enters Collider on the Right Side when facing right
			else if (faceRight && other.transform.position.x < transform.position.x) {
				flipFacing ();
			}


			willFlip = false;
			charging = true; 
			startChargeTime = Time.time + chargeTime;
		}
 
	}
	void OnTriggerStay2D(Collider2D other){

			if (other.tag == "Player") {
				if (startChargeTime < Time.time) {
					if (!faceRight)
						enemyRB.AddForce (new Vector2 (-1, 0) * chargeSpeed);
					else enemyRB.AddForce (new Vector2 (1, 0) * chargeSpeed);
					enemyAnim.SetBool ("Charge", charging);




			}

		}
	}
	void OnTriggerExit2D(Collider2D other) {
		if(other.tag == "Player") {
			willFlip = true;
			charging = false;		
			enemyRB.velocity = new Vector2(0f,0f);
			enemyAnim.SetBool("Charge", charging);

		}
	}


		void flipFacing() {
		
		if(!willFlip) return;
			float facingX = enemyGraphic.transform.localScale.x;
			facingX *= -1f;
			enemyGraphic.transform.localScale = new Vector3 (facingX, enemyGraphic.transform.localScale.y, enemyGraphic.transform.localScale.z);
			faceRight = ! faceRight;
		}



	}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour {

    public float moveSpeed;
    public bool moveRight;
    private Rigidbody2D rigid2D;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatisawall;
    private bool wallHitting;


	// Use this for initialization
	void Start () {

        rigid2D = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {

        wallHitting = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatisawall);

        if(wallHitting)


        if (moveRight)
        {
            rigid2D.velocity = new Vector2(moveSpeed, rigid2D.velocity.y);
        }
        else
        {
            rigid2D.velocity = new Vector2(-moveSpeed, rigid2D.velocity.y);
        }

    }
}

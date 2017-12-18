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

    private bool NotatEdge;
    public Transform edgeCheck;


	// Use this for initialization
	void Start () {

        rigid2D = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {

        wallHitting = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatisawall);

        NotatEdge = Physics2D.OverlapCircle(edgeCheck.position, wallCheckRadius, whatisawall);

        if (wallHitting || !NotatEdge)
            moveRight = !moveRight;

        if (moveRight)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            rigid2D.velocity = new Vector2(moveSpeed, rigid2D.velocity.y);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            rigid2D.velocity = new Vector2(-moveSpeed, rigid2D.velocity.y);
        }

    }
}

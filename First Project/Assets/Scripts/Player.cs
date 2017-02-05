using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Player : MonoBehaviour 
{
	private Rigidbody2D body; 
	public float speed; 
	public float jumpSpeed;
	public Transform groundCheck; 
	public bool isGrounded; 
	public int coinAmount; 
	public Text score; 

	// Use this for initialization
	void Start () 
	{
		body = GetComponent <Rigidbody2D> (); 
	}

	//
	void Update ()
	{
		if ( isGrounded == true && Input.GetButtonDown ("Jump")) 
		{
			body.velocity = new Vector2 ( body.velocity.x, jumpSpeed );
		}
	}


	// Update is called once per frame
	void FixedUpdate () 
	{
		if ( Physics2D.OverlapPoint (groundCheck.position) == null ) 
		{
			isGrounded = false; 
		}
		else 
		{
			isGrounded = true; 
		}
//		float horizontal = Input.GetAxisRaw ("Horizontal");
		float horizontal = Input.GetAxis ("Horizontal");
		body.velocity = new Vector2 ( horizontal * speed, body.velocity.y);
	}

	void OnTriggerEnter2D ( Collider2D other )
	{
		Destroy (other.gameObject); 

		coinAmount++; 
		score.text = "Score : " + coinAmount.ToString ();
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour {
    public Rigidbody2D rb ;

    // Use this for initialization
    private float  speed = 6f;
    public float moveup;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var Rigidbody2D = GetComponent<Rigidbody2D>();
        if (Input.GetKey(KeyCode.LeftArrow)&(transform.position.x>-7.60f))
            transform.position += Vector3.left * Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.RightArrow)&(transform.position.x<7.50f))
            transform.position += Vector3.right * Time.deltaTime * speed;
    }
    void FixedUpdate()
    {
        moveup=Input.GetAxis("Vertical");
        rb.velocity = new Vector2(rb.velocity.x,moveup*speed);

    }


     
}


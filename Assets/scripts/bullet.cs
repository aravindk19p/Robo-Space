using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
	public GameObject blood;

	public float speed = 10f;
	public Rigidbody2D rb;


	// Use this for initialization
	void Start () {
		rb.velocity = transform.right * speed;
	}

	void Update()
	{
		Destroy(this.gameObject,2.0f);
	}
	
	// Update is called once per frame
private void OnTriggerEnter2D(Collider2D collision)
    {
        if  (collision.gameObject.tag == "Enemy")
	
			{
				
            Destroy(collision.gameObject);
				Destroy(this.gameObject);
				Instantiate (blood, transform.position, Quaternion.identity);
				
				

				
			}
			 if  (collision.gameObject.tag == "Ast")
	
			{
				 Destroy(collision.gameObject);
            	Destroy(this.gameObject);
				Instantiate (blood, transform.position, Quaternion.identity);
				

				
			}
	if  (collision.gameObject.tag == "Asts")
	
			{
				 Destroy(collision.gameObject);
            	Destroy(this.gameObject);
				Instantiate (blood, transform.position, Quaternion.identity);
				

				
			}
	
			
    }
}

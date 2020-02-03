using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour {
public int speed = 6;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.left * Time.deltaTime * speed;
		
	}
	 private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
             
             GameManager.instance.addscore(10);
			// Destroy(collision.gameObject);
             Destroy(this.gameObject);
             Destroy(gameObject);
             
           
        }
        
	}

}

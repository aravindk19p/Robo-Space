﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astdestroy : MonoBehaviour { 
   //public int speed = 4;

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update()
    {

       //transform.position += Vector3.left * Time.deltaTime * speed;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if  (collision.gameObject.tag == "Ast")

            Destroy(collision.gameObject);
            
    }
    
    
    

}
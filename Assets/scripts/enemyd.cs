using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyd : MonoBehaviour
 { 
    

    // Use this for initialization
    private int speed = 6;
public GameObject blood;
    //public GameObject blood;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.down * Time.deltaTime * speed;

    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
               Instantiate (blood, transform.position, Quaternion.identity);
            GameManager.instance.showgameendpanel();
			Destroy(col.gameObject);
                Destroy(this.gameObject);

        }
          
    }
        
    
    
}

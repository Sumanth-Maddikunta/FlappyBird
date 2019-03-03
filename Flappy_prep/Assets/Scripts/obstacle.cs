using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class obstacle : MonoBehaviour
{
    public float speed = 5f;

    

    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if(transform.position.x<-15f)
        {
            transform.position = new Vector3(10, transform.position.y,transform.position.z);
        }

        
	}

    
    
}

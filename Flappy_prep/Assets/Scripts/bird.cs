using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class bird : MonoBehaviour
{
    Rigidbody rb;

    int score = 0;
    public Text scoreText;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetMouseButtonDown(0))
        {
            //rb.AddForce(0,10, 0,ForceMode.Impulse);
            rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
            Debug.Log(score);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Obstacle")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "score")
        {
            score++;
            scoreText.text = " Score :" + score.ToString();
            Debug.Log(score);
        }
    }
}

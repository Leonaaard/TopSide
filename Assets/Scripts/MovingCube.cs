using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour {

    public float speed;

    private Rigidbody rb;
    private Renderer rend;

	void Start () {
        
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();

        //Randomize color
        rend.material.color = Random.ColorHSV(0f, 1f, 0f, 1f, 1f, 1f);

        //Randomize size
        float result = Random.Range(1, 3);
        if (result == 1){
            transform.localScale = new Vector3 (1, 50, 1);
        } else if (result == 2){
            transform.localScale = new Vector3(1, 1, 50);
        }

        // Randomize position
        Vector3 direction = new Vector3(-1, 0, 0);
        rb.velocity = direction * speed;

	}

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour {
    int health = -20;
    bool gameOver = false;
	// Use this for initialization
	void Start () {
		if (health <= 0) {
            gameOver = true;
        }
        if(gameOver == true)
        {
            Debug.Log("Game OVER!");
        }
        else
        {
            Debug.Log("You alive!");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

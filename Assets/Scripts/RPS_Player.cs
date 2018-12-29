using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPS_Player : MonoBehaviour
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public string Shoot()
    {
        return (new string[3] { "Rock", "Paper", "Scissors" })[Random.Range(0, 3)];
    }
}

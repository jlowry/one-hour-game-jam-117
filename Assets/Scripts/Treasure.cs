﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            Debug.Log("Victory!!");
        }
    }
}

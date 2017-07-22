using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDig : MonoBehaviour {
    private int diggable;

    private PlayerEnergy playerEnergy;


    // Use this for initialization
    void Awake () {
	    diggable = LayerMask.GetMask("Diggable");
        playerEnergy = GetComponent<PlayerEnergy>();
    }
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButtonDown("Fire1")) {
	        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, 1.0F, diggable);
	        if (hit.collider != null) {
	            hit.collider.gameObject.SetActive(false);
                Debug.Log("Dig!");
	            playerEnergy.DecreaseEnergy(1);
            }
        }
	}

    void OnTriggerEnter() {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {
    public int dimensions_x = 10;
    public int dimensions_y = 2;
    public GameObject treasurePrefab;
    public GameObject groundPrefab;
    private GameObject[,] level;

	// Use this for initialization
	void Start () {
        level = new GameObject[dimensions_x,dimensions_x];

	    for (int i = 0; i < dimensions_x; i++) {
	        for (int j = 0; j < dimensions_y; j++) {
                var ground = Instantiate(groundPrefab);
                ground.transform.position = new Vector2( i -6, j -4 );
                level[i,j] = ground;
	        }
	    }

	    var treasureLocation = new Vector2(Random.Range(-6, dimensions_x-6), Random.Range(-4, -2));
	    Instantiate(treasurePrefab, treasureLocation, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

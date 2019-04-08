using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

    GameManager scoreUpdate;
	// Use this for initialization
	void Start () {
        scoreUpdate = FindObjectOfType<GameManager>();
		
	}

    // Update is called once per frame
    private void OnMouseDown()
    {
        scoreUpdate.IncrementScore();
        Destroy(this.gameObject);
    }
}

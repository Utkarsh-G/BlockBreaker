using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

    LevelManager myLvlManager;
    //public float gravX;
    //public float gravY;
    //public float gravZ;
	// Use this for initialization
	void Start () {

        //Physics.gravity = new Vector3(gravX, gravY, gravZ);
        myLvlManager = GameObject.FindObjectOfType<LevelManager>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Collision detection

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Loss Collision happened. You Lost."); 
		Hedge.breakableCount = 0;
        myLvlManager.LoadLevel(5);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        print("Trigger happened");
    }
}

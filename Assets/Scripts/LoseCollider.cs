using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

    public LevelManager myLvlManager;
    //public float gravX;
    //public float gravY;
    //public float gravZ;
	// Use this for initialization
	void Start () {

        //Physics.gravity = new Vector3(gravX, gravY, gravZ);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Collision detection

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision happened");
        myLvlManager.LoadLevel(2);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        print("Trigger happened");
    }
}

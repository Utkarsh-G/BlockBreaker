using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    
    public float gravX;
    public float gravY;
    public float gravZ;
    public float usegrav;
    CircleCollider2D coll;

    // Use this for initialization
    void Start () {

        Physics.gravity = new Vector3(gravX, gravY, gravZ);
        coll = GetComponent<CircleCollider2D>();
        usegrav = 1f;

    }
	
	// Update is called once per frame
	void Update () {
        Physics2D.gravity = new Vector3(gravX, gravY, gravZ);
        //Collider coll = GetComponent<Collider>();
        coll.attachedRigidbody.gravityScale = usegrav;
	}
}

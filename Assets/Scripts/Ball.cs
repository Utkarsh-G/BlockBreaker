using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    LionBlock myBlock;
    private Vector3 BlockToBallVector;
    bool isStartingPosition;
    // Use this for initialization
    void Start () {

        myBlock = GameObject.FindObjectOfType<LionBlock>();
        BlockToBallVector = this.transform.position - myBlock.transform.position;

        print(BlockToBallVector);

        isStartingPosition = true;
        Physics2D.gravity = new Vector2(-1f, 0f);

        //AudioSource myAudio = this.GetComponent<AudioSource>();

        //myAudio.Play();
    }
	
	// Update is called once per frame
	void Update () {
        if (isStartingPosition)
        {
            this.transform.position = myBlock.transform.position + BlockToBallVector;

        }

        if (Input.GetMouseButtonDown(0) && isStartingPosition)
        {
            isStartingPosition = false;
            Rigidbody2D myBody = GetComponent<Rigidbody2D>();
            myBody.velocity = new Vector2(10f, 2f);
            myBody.gravityScale = 1;
        }
   
	}

    void OnCollisionEnter2D (Collision2D collision)
    {
        Vector2 tweak = new Vector2(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f));

        Debug.Log(tweak);

        if (!isStartingPosition)
        {
            Rigidbody2D rbody2d = GetComponent<Rigidbody2D>();
            rbody2d.velocity += tweak;
        }

    }


}

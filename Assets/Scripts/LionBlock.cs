using UnityEngine;
using System.Collections;

public class LionBlock : MonoBehaviour {
	
	public bool autoPlay = false;  

	private Ball ball;

	// Use this for initialization
	void Start () {

		ball = GameObject.FindObjectOfType<Ball> ();
		Debug.Log (ball);
	}
	
	// Update is called once per frame
	void Update () {
		if (!autoPlay) {
			MoveWithMouse ();
		} else {
			TrackBall ();
		}
	}

	void MoveWithMouse(){
		float mousePosInBlocks;
		mousePosInBlocks = Input.mousePosition.y / Screen.height * 12;
		//print(mousePosInBlocks);
		this.transform.position = new Vector3(this.transform.position.x, Mathf.Clamp(mousePosInBlocks-6,-5.5f,5.5f), 0f);
	
	}

	void TrackBall(){
		float ballPosInBlocks;
		ballPosInBlocks = ball.transform.position.y;
		this.transform.position = new Vector3(this.transform.position.x, Mathf.Clamp(ballPosInBlocks,-5.5f,5.5f), 0f);
	}
}

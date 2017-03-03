using UnityEngine;
using System.Collections;

public class LionBlock : MonoBehaviour {
    float mousePosInBlocks;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        mousePosInBlocks = Input.mousePosition.y / Screen.height * 12;
        print(mousePosInBlocks);
        this.transform.position = new Vector3(this.transform.position.x, Mathf.Clamp(mousePosInBlocks-6,-5.5f,5.5f), 0f);
	}
}

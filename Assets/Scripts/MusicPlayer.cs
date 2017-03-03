using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer _instanceOfMP = null;

	// Use this for initialization
	void Awake () {

        if (_instanceOfMP != null)
        {
            Destroy(gameObject);
            Debug.Log("Duplicate music player destroyed.");
        }
        else
        {
            _instanceOfMP = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

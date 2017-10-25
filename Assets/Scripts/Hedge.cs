using UnityEngine;
using System.Collections;

public class Hedge : MonoBehaviour {

    public static int breakableCount = 0;

    public Sprite[] hitSprites;
    public AudioClip hedgeTear1;
    public AudioClip hedgeTear2;
    public int maxHits;
    public int timesHits;
    LevelManager myLvlManager;
	// Use this for initialization
	void Start () {
	
        maxHits = 2;
        myLvlManager = GameObject.FindObjectOfType<LevelManager>();
        breakableCount++;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionExit2D(Collision2D collision)
    {
        //print("collision with tag " + collision.gameObject.name);
        if (collision.gameObject.name == "Ball")
        {
			
			//Debug.Log("Collsion with Ball happened. Hedges remaining:" + breakableCount);  
            timesHits++;
            if (maxHits <= timesHits)
            {
                breakableCount--;
                //Debug.Log("# of bricks:" + Hedge.breakableCount);
                myLvlManager.BrickDestroyed();
                AudioSource.PlayClipAtPoint(hedgeTear2, transform.position, 0.76f);
                gameObject.SetActive(false);
            }
            else
            {
                LoadSprites();
                AudioSource.PlayClipAtPoint(hedgeTear1, transform.position, 0.76f);

            }
        }

        //SimulateWin();

    }

    void SimulateWin()
    {
        myLvlManager.LoadNextLevel();
    }

    void LoadSprites()
    {
        int spriteIndex = timesHits - 1;
        SpriteRenderer mySR = this.GetComponent<SpriteRenderer>();
        mySR.sprite = hitSprites[spriteIndex];
    }
}

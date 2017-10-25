using UnityEngine;
using System.Collections;
//using UnityEditor.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LoadLevel(int sceneIndex)
    {
        Debug.Log("Level load requested for: " + sceneIndex);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex);
        initializeHedgeCount();


    }

    public void LoadNextLevel()
    {
        //Debug.Log("Level load requested for: " + sceneIndex);
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);
        initializeHedgeCount();
    }

    public void QuitRequest()
    {
        Debug.Log("Quit requested.");

    }

    void initializeHedgeCount()
    {
        //Hedge.breakableCount = 7;
        Debug.Log(Hedge.breakableCount);
    }

    public void BrickDestroyed()
    {
        if(Hedge.breakableCount <= 0)
        {
            LoadNextLevel();
        }
    }
	
}

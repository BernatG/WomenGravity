using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoopScript : MonoBehaviour
{

    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        // temporary reset condition for checking the loop works
        if (Player.GetComponent<Transform>().position.y < -3)
        {
            Debug.Log("Try to loop");
            Loop();
        }
    }

    // Resets the current scene
    void Loop()
    {
        Debug.Log("Looped");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}



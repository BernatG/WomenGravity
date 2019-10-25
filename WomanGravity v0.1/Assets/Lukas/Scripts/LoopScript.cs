using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoopScript : MonoBehaviour
{

    public GameObject Player;

    public float WaitTime = 60.0f;
    public float Timer = 0.0f;


    // Keeps track of how many of a specific items the player has picked up
    public int Item1Collected;
    public int Item2Collected;
    public int Item3Collected;


    // Keeps track of which itemtiers the player has finished
    public bool ItemTier1;
    public bool ItemTier2;
    public bool ItemTier3;


    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;


        // Checks if you have collected the right amount of items for a tier that is unlocked and the player hasn't completed yet, and then adjust the waittime and timer
        if (Item1Collected == 3 && ItemTier1 == false)
        {
            Timer = 0.0f;
            WaitTime = 120.0f;
            ItemTier1 = true;
        }
        else if (Item2Collected == 5 && ItemTier2 == false && ItemTier1 == true)
        {
            Timer = 0.0f;
            WaitTime = 180.0f;
            ItemTier2 = true;
        }
        else if (Item3Collected == 5 && ItemTier3 == false && ItemTier2 == true)
        {
            Timer = 0.0f;
            WaitTime = 300.0f;
            ItemTier3 = true;
        }
        // Insert other if statements here, if there needs to be more item tiers
        // Checks if the player has run out of time and loops if so
        else if (Timer > WaitTime)
        {
            Debug.Log("Ran out of time");
            Loop();
        }
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.transform.CompareTag("Item1"))
        {
            Item1Collected++;
        }
        if (col.transform.CompareTag("Item2"))
        {
            Item2Collected++;
        }
        if (col.transform.CompareTag("Item3"))
        {
            Item3Collected++;
        }
    }
    

    // Resets the current scene
    void Loop()
    {
        Debug.Log("Looped");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}



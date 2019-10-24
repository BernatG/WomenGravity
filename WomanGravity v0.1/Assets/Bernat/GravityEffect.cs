using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GravityEffect : MonoBehaviour
{     
    private Rigidbody rb;
    private Move player;
    //private Animator anim;
    

    private bool gravedad = true;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GetComponent<Move>();
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //anim.Play("Take 001");
        if (Input.GetKeyDown(KeyCode.I))
        {          
            if (gravedad == true)
            {
                Physics.gravity = new Vector3(0, 9.81f * 25, 0);
                rb.transform.eulerAngles = new Vector3(180f, 90f, 0);
            }
            else
            {             
                Physics.gravity = new Vector3(0, -9.81f * 25, 0);
                rb.transform.eulerAngles = new Vector3(0f, -90f, 0);                
            }
            gravedad = !gravedad;
        }       


    }

}

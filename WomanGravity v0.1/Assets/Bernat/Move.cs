using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rb;
    //public float speed;
    public float speed = 2f;
    public Animator anim;



    // Use this for initialization
    void Start()
    {
        
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        anim.Play("Take 001");
        rb.velocity = new Vector3 (speed, 0 ,0);
    }



    // Update is called once per frame
    void FixedUpdate()
    {
     
    }

}

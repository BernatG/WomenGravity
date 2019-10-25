using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rb;
    //public float speed;
    public float speed = 2f;
    public GameObject canvasDead;
    //public Animator anim;



    // Use this for initialization
    void Start()
    {
        canvasDead.gameObject.SetActive(false);
        rb = gameObject.GetComponent<Rigidbody>();
        Time.timeScale = 1;
    }

    private void Update()
    {
        //anim.Play("Take 001");
        rb.velocity = new Vector3 (speed, 0 ,0);
    }



    // Update is called once per frame
    void FixedUpdate()
    {
     
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "vehicle")
        {
            Debug.Log("Collision");
            canvasDead.gameObject.SetActive(true);
            Time.timeScale = 0;

        }


    }

}

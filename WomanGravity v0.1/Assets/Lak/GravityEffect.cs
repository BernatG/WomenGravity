using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityEffect : MonoBehaviour
{

    private Rigidbody2D rb;
    private Move player;

    private bool top;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GetComponent<Move>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            rb.gravityScale *= -1;
            Rotation();
        }
    }

    void Rotation()
    {
        if (top == false)
        {
            transform.eulerAngles = new Vector3(0, 0, 180f);
        }
        else
        {
            transform.eulerAngles = Vector3.zero;
        }
        //player.movimiento = !player.movingLeft;
        top = !top;
    }
}

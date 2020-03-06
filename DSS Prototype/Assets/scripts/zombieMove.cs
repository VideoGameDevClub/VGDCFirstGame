using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieMove : MonoBehaviour
{
    public float speed = 2f;
    public Rigidbody2D rb;
    Transform player;
    Vector2 lookDir;
    public int initDelay = 10;
    float delay;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        delay = initDelay;
    }


    void FixedUpdate()
    {
        //try to make a delayed reaction
        DelayedMove();
    }

    void DelayedMove()
    {
        //movement
        Vector2 target = new Vector2(player.position.x, player.position.y);
        Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);
        rb.MovePosition(newPos);
        //rotation
        lookDir = target - newPos;
        rb.rotation = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
    }
}

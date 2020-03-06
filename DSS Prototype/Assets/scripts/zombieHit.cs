using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieHit : MonoBehaviour
{
    public Animation zombieHitAnim;
    public GameObject zombieSpawn;
    public int HP = 10;
    public bool isBig = false;

    void OnCollisionEnter2D (Collision2D collision)
    {
        if(collision.collider.tag == "Bullet")
        {
            zombieHitAnim.Play();
            HP--;
            if(HP < 1)
            { 
                //add death animation
                Destroy(gameObject);

                //big spawns smalls
                if (isBig)
                {
                    Instantiate(zombieSpawn, transform.position, Quaternion.identity);
                }
            }
        }
    }
}

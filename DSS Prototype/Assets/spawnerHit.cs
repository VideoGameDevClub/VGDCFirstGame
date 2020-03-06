using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerHit : MonoBehaviour
{
    int currHealth;
    public healthBar hb;
    public int maxHealth = 50;

    void Start()
    {
        hb.setMaxHealth(maxHealth);
        currHealth = maxHealth;
    }

        
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.tag == "Bullet")
        {
            TakeDamage(1);
        }
    }


    void TakeDamage(int damage)
    {
        currHealth -= damage;
        hb.setHealth(currHealth);

        if(currHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}

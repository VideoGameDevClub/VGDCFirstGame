using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currHealth;

    public healthBar healthBar;

    void Start()
    {
        currHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    void TakeDamage(int damage)
    {
        currHealth -= damage;
        healthBar.setHealth(currHealth);
    }
}

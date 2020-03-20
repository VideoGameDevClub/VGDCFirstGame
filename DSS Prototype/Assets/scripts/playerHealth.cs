using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if(currHealth == 0)
        {
            PlayerDeath();
        }
    }

    void PlayerDeath()
    {
        SceneManager.LoadScene("Zombie_Shooter");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Debug.Log("Player hit");
            TakeDamage(1);
        }
    }
}

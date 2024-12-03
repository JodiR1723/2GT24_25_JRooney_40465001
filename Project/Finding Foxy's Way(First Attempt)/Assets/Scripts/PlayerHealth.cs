using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Variables
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        // Ensure health doesn't go below 0
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }

        // Update health bar
        healthBar.SetHealth(currentHealth);

        //Player death if health is 0
        if (currentHealth == 0)
        {
            Die();
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        // Apply damage from a certain object
        if (collision.gameObject.CompareTag("Damage"))
        {
            TakeDamage(25);
        }
    }

    //When health reaches 0, player's dies
    void Die()
    {
        // Temporary Game stopper 
        Debug.Log("Player is dead!");
        // Deactivate player object
        gameObject.SetActive(false);
    }

}


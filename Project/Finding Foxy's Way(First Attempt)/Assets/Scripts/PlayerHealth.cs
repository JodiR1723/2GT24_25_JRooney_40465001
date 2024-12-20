using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerHealth : MonoBehaviour
{
    // Variables
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    public TextMeshProUGUI gameOverText;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        //Game Over text is hidden
        gameOverText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            // Show the Game Over text
            gameOverText.gameObject.SetActive(true);

            // Pausing the game
            Time.timeScale = 0;
        }

    }
      

}


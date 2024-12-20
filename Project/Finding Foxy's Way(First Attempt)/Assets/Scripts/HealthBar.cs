using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    //Variables
    public Slider slider;

    void Update()
    {
        
    }
    public void SetHealth(int health)
    {
        slider.value = health;
    }
    public void SetMaxHealth(int health) 
    {
        slider.maxValue = health;
        slider.value = health;
    }
}

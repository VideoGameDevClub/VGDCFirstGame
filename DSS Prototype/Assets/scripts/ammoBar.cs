using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammoBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;


    public void setMaxAmmo(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);
    }

    public void setAmmo(int ammo)
    {
        slider.value = ammo;

        fill.color = gradient.Evaluate(slider.normalizedValue); 
    }
}

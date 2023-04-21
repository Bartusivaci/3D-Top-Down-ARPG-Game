using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float baseMaxHealth = 150f;
    public float currentHealth;

    public float baseHealthRegen = 2f;

    public float baseMaxMana = 100f;
    public float currentMana;

    public float baseManaRegen = 5f;


    private void Start()
    {
        currentHealth = baseMaxHealth;
        currentMana = baseMaxMana;
    }



}

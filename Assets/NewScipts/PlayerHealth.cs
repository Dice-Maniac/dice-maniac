using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    // Player's health point
    public float HP;
    private float MaxHP;
    public Image hpima;

    private void Start()
    {
        // Initial players' HP at start of the game
        MaxHP = HP;
    }

    private void Update()
    {

        // Update player's HpP
        hpima.fillAmount = HP / MaxHP;

    }

    // Function when player gets damage
    public void TakeDamage(float damage)
    {
        if (HP <= 0) return;

        HP -= damage;
        if (HP<=0)
        {
            //Die TODO
        }
    }

}

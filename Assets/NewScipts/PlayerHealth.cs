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

    public bool isDun;

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

    public void  SetHPColor(){
        isDun = true;
        hpima.color = Color.gray;
    }

    // Function when player gets damage
    public void TakeDamage(float damage)
    {
        if (HP <= 0) return;
        if  (isDun){
            damage += 3;
            isDun = false;
            hpima.color = Color.green;
        }
        HP -= damage;
        if (HP<=0)
        {
            //Die TODO
        }
    }

}

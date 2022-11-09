using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float HP;//生命值
    private float MaxHP;//最大生命值
    public Image hpima;

    private void Start()
    {
        MaxHP = HP;
    }

    private void Update()
    {

        //实时更新血量Ui条
        hpima.fillAmount = HP / MaxHP;

    }

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

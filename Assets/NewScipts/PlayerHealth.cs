using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float HP;//����ֵ
    private float MaxHP;//�������ֵ
    public Image hpima;

    private void Start()
    {
        MaxHP = HP;
    }

    private void Update()
    {

        //ʵʱ����Ѫ��Ui��
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

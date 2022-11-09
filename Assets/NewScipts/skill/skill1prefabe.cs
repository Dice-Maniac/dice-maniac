using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill1prefabe : MonoBehaviour
{
    [HideInInspector]
    public int targetplayerid;
    public float Damage = 10;
    public float speed = 3;
    public float destime = 1;

    private void Start()
    {
        Destroy(gameObject,destime);
    }

    public void SetTrans(Vector3 targetvector3)
    {     
        transform.right= targetvector3 - transform.position;
    }

    private void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime*speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Player")
        {
            if (PlayerSkillManager.Instance.targetplayer==collision.GetComponent<PlayerHealth>())
            {
                PlayerSkillManager.Instance.targetplayer.TakeDamage(Damage);
            }           
        }
    }

}

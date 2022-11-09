using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerskill : MonoBehaviour
{

    public bool canrelease = true;

    public float Damage = 10;
    public float AtkDis = 2;
    public Animator weaponAnima;

    private void Start()
    {
        weaponAnima = transform.GetChild(4).GetComponent<Animator>();
    }
    public void Releaseskill3()
    {
        weaponAnima.gameObject.SetActive(true);
        weaponAnima.SetTrigger("atk");
        StartCoroutine(TakeDamage());

    }

    IEnumerator TakeDamage()
    {
        yield return new WaitForSeconds(0.6f);
        if (Vector3.Distance(transform.position,PlayerSkillManager.Instance.targetplayer.transform.position)<AtkDis)
        {
            PlayerSkillManager.Instance.targetplayer.TakeDamage(10);
        }
        yield return new WaitForSeconds(1f);
        weaponAnima.gameObject.SetActive(false);

    }

}

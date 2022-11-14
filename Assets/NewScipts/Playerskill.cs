using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerskill : MonoBehaviour
{

    // check for status whether player can release skill or not
    public bool canrelease = true;

    // data which can be modified in the inspector
    public float Damage = 10;
    public float AtkDis = 2;

    // get the hammer animator component
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

    // function for triggering animator and causing damage
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

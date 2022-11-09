using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class gamecontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player1;
    public GameObject player2;
    public CinemachineVirtualCamera vcam;
    private int term;
    public int rollLimit;
    public int moveLimit;
    void Start()
    {
        term = 0;
        rollLimit = 0;
        moveLimit = 0;
        player2.GetComponent<movescript>().enabled = false;
        vcam = vcam.GetComponent<CinemachineVirtualCamera>();
        vcam.m_Follow = player1.transform;

    }

    public int Getterm()
    {
        return term;
    }
    public void changeplayer()
    {
        if (term == 0)
        {
            rollLimit = 0;
            moveLimit = 0;
            player1.GetComponent<movescript>().enabled = false;
            player2.GetComponent<movescript>().enabled = true;
            term = 1;
            vcam.m_Follow = player2.transform;

            //updata nowplayer
            PlayerSkillManager.Instance.NowPlayer = 1;
            PlayerSkillManager.Instance.targetplayer = player1.GetComponent<PlayerHealth>();
        }
        else
        {   
            rollLimit = 0;
            moveLimit = 0;
            player2.GetComponent<movescript>().enabled = false;
            player1.GetComponent<movescript>().enabled = true;
            term = 0;
            vcam.m_Follow = player1.transform;

            //updata nowplayer
            PlayerSkillManager.Instance.NowPlayer = 0;
            PlayerSkillManager.Instance.targetplayer = player2.GetComponent<PlayerHealth>();
        }




    }
}
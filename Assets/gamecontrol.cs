using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
//The gamecontrol function including end turn function, camera control, and recording turn
public class gamecontrol : MonoBehaviour
{
    // Two players 
    public GameObject player1;
    public GameObject player2;
    //camera of player
    public CinemachineVirtualCamera vcam;
    private int term;
    //limit of roll and moving 
    public int rollLimit;
    public int moveLimit;
    //Game start condition, everything is set to zero
    void Start()
    {
        term = 0;
        rollLimit = 0;
        moveLimit = 0;
        player2.GetComponent<movescript>().enabled = false;
        vcam = vcam.GetComponent<CinemachineVirtualCamera>();
        vcam.m_Follow = player1.transform;

    }
    //get turn
    public int Getterm()
    {
        return term;
    }
    //end turn and swtich player and switch the camera
    public void changeplayer()
    {
        if (term == 0)
        {
            //reset the limit, switch to another player
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
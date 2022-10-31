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
    void Start()
    {
        term = 0;
        player2.GetComponent<movescript>().enabled = false;
        vcam = vcam.GetComponent<CinemachineVirtualCamera>();
        vcam.m_Follow = player1.transform;

    }


    public void changeplayer()
    {
        if (term == 0)
        {
            player1.GetComponent<movescript>().enabled = false;
            player2.GetComponent<movescript>().enabled = true;
            term = 1;
            vcam.m_Follow = player2.transform;
        }
        else
        {
            player2.GetComponent<movescript>().enabled = false;
            player1.GetComponent<movescript>().enabled = true;
            term = 0;
            vcam.m_Follow = player1.transform;
        }

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSkillManager : MonoBehaviour
{

    public static PlayerSkillManager Instance;


    public Button skill1;
    public Button skill2;
    public Button skill3;
    private bool iscanskill1 = false;


    public int NowPlayer;//(0) player1 (1)player2
    [HideInInspector]
    public PlayerHealth targetplayer;
    [HideInInspector]
    public gamecontrol gamecrol;
    [HideInInspector]
    public GameObject Player1;
    [HideInInspector]
    public GameObject Player2;
    private GameObject skill1prefabe;
    private void Awake()
    {
        Instance = this;

        Player1 = GameObject.Find("player 1");
        Player2 = GameObject.Find("player 2");

        gamecrol = GameObject.Find("gamecontrol").GetComponent<gamecontrol>();
        targetplayer = Player1.GetComponent<PlayerHealth>();
        //load prefabes
        skill1prefabe = Resources.Load<GameObject>("fireball");

        //button onclick
        skill1.onClick.AddListener(skill1btnclick);
        skill3.onClick.AddListener(skill3btnclick);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)&&iscanskill1)
        {
            iscanskill1 = false;
            Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
            Vector3 mousePosOnScreen = Input.mousePosition;
            mousePosOnScreen.z = screenPos.z;
            Vector3 mousePosInWorld = Camera.main.ScreenToWorldPoint(mousePosOnScreen);
            Vector3 targetpos = mousePosInWorld;

            if (NowPlayer ==0)
            {

                GameObject go = Instantiate(skill1prefabe, Player1.transform.position, Quaternion.identity);
                go.GetComponent<skill1prefabe>().SetTrans(new Vector3(targetpos.x,targetpos.y,1));
                go.GetComponent<skill1prefabe>().targetplayerid = 1;
            }
            else
            {
                GameObject go = Instantiate(skill1prefabe, Player2.transform.position, Quaternion.identity);
                go.GetComponent<skill1prefabe>().SetTrans(new Vector3(targetpos.x, targetpos.y, 1));
                go.GetComponent<skill1prefabe>().targetplayerid = 0;
            }

        }

   

    }


    public void skill1btnclick()
    {
        iscanskill1 = true;
    }

    public void skill2btnclick()
    {


    }
    public void skill3btnclick()
    {
        if (NowPlayer==1)
        {
            Player2.GetComponent<Playerskill>().Releaseskill3();

        }
    }


}

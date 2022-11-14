using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//The properties and data of each player, including health
public class playerscript : MonoBehaviour
{
    [SerializeField] HealthBar healthbar;
    private float health;
    private int dicenum;
    private int movement; 
    // update health bar of each player at the start of the game
    void Start()
    {
        if(healthbar!=null) healthbar.SetColor(Color.green);
        health = 1f;
    }
    // update heath bar when damaged 
    void reducehealth(int x) {
        if (x == 1&&healthbar!=null) {
            healthbar.SetSize(health - 0.25f);
            healthbar.SetColor(Color.red);
        }    
    }
    

}

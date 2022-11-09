using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    [SerializeField] HealthBar healthbar;
    private float health;
    private int dicenum;
    private int movement; 
    // Start is called before the first frame update
    void Start()
    {
        if(healthbar!=null) healthbar.SetColor(Color.green);
        health = 1f;
    }
    void reducehealth(int x) {
        if (x == 1&&healthbar!=null) {
            healthbar.SetSize(health - 0.25f);
            healthbar.SetColor(Color.red);
        }    
    }
    

}

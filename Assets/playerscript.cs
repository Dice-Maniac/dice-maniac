using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    [SerializeField] HealthBar healthbar;
    private int health;
    private int dicenum;
    private int movement;
    // Start is called before the first frame update
    void Start()
    {
        healthbar.SetSize(.4f);
       
    }


}

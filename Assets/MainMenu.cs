using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //the playing scene has index of 1. jump to the playing scene when click the button
    public void Play(){
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
        SceneManager.LoadScene(1);
    }
    
    
    public void Quit(){
        Application.Quit();
    }
}

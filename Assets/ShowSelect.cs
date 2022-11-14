using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Show the selection button when chosing a dice action is needed
public class ShowSelect : MonoBehaviour
{
    public GameObject Image;
    public GameObject Image2;
    public GameObject Image3;
    public GameObject Image4;
    // Show the "Select Dice" buttons
    public void OpenChoose()
    {
        Image.SetActive(true);
        Image2.SetActive(true);
        Image3.SetActive(true);
        Image4.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public bool ActiveInfo = false;
    public GameObject Info;

    public void PressButton()
    {
        if (ActiveInfo)
        {
            Info.SetActive(false);
            ActiveInfo = false;
            // GetComponent<Animator>().enabled = false;
        }
        else
        {
            Info.SetActive(true);
            ActiveInfo = true;
        }
    }
}

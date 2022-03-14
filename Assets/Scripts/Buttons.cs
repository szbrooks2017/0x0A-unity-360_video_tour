using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public bool ActiveInfo = false;
    public GameObject Info;

    /// <summary> Method <c>PressButton</c> Activates an info object</summary>
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

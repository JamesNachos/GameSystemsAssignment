using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customisation : MonoBehaviour
{

    private void OnGUI()
    {
        CustomiseOnGUI();
    }

    private void CustomiseOnGUI()
    {
        float currently = 40;
        int i = 0;

        //skin
        if(GUI.Button(new Rect(20, 40, 20, 20),"<"))
        {
            Debug.Log("Left");
        }
        GUI.Label(new Rect(45, 40, 60, 20), "Skin");
        if (GUI.Button(new Rect(90, 40, 20, 20),">"))
        {
            Debug.Log("Right");
        }

        //eyes
        if (GUI.Button(new Rect(20, 70, 20, 20), "<"))
        {
            Debug.Log("Left");
        }
        GUI.Label(new Rect(45, 40, 60, 20), "Skin");
        if (GUI.Button(new Rect(90, 40, 20, 20), ">"))
        {
            Debug.Log("Right");
        }

        //mouth
        if (GUI.Button(new Rect(20, 40, 20, 20), "<"))
        {
            Debug.Log("Left");
        }
        GUI.Label(new Rect(45, 40, 60, 20), "Skin");
        if (GUI.Button(new Rect(90, 40, 20, 20), ">"))
        {
            Debug.Log("Right");
        }
    }






}

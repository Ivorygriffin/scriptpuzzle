using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetSubmit : MonoBehaviour
{
    public GameObject platform1;
    public GameObject platform2;
    public GameObject platform3;
    public GameObject platform4;
    public GameObject platform5;
    public GameObject platform6;
    public GameObject platform7;
    public GameObject platform8;
    public GameObject platform9;
    public Material black;
    public Material green;
    public Material red;
    public Material yellow;
    public Material white;
    public Material blue;
    void Start()
    {
        
    }
    public void CorrectCheck()
    {
        if (platform1.GetComponent<Renderer>().material.name == blue.name + " (Instance)")
        {
            Text.print("Level Complete");
        } 
    }

    public void ResetLevel()
    {
        //player back to start platforms back to m_white player back to black 
    }

}

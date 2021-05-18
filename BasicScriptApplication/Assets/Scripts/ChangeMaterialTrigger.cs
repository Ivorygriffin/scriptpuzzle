using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialTrigger : MonoBehaviour
{
    public GameObject player;
    public Material black;
    public Material green;
    public Material red;
    public Material yellow;
    public Material white;
    public Material blue;

    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider collidedObject)
    {
        if (collidedObject.gameObject.tag == "Player")
        {

        }
        if (player.GetComponent<Renderer>().material.name == black.name + " (Instance)")
        {
            this.gameObject.GetComponent<Renderer>().material.name = black.name;
        }
        else if (player.GetComponent<Renderer>().material.name == red.name + " (Instance)")
        {
            this.gameObject.GetComponent<Renderer>().material.name = red.name;
        }
        else if (player.GetComponent<Renderer>().material.name == green.name + " (Instance)")
        {
            this.gameObject.GetComponent<Renderer>().material.name = green.name;
        }
        else if (player.GetComponent<Renderer>().material.name == blue.name + " (Instance)")
        {
            this.gameObject.GetComponent<Renderer>().material.name = blue.name;
        }
        else if (player.GetComponent<Renderer>().material.name == yellow.name + " (Instance) ")
        {
            this.gameObject.GetComponent<Renderer>().material.name = yellow.name;
        }
        else if (player.GetComponent<Renderer>().material.name == white.name + " (Instance) ") ;
        {
            this.gameObject.GetComponent<Renderer>().material.name = white.name;
        }
        



    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

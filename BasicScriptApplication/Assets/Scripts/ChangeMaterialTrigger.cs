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
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("collided");
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player Detected");
           
            if (player.GetComponent<Renderer>().material.name == red.name + " (Instance)")
            {
                Debug.Log("detected red material");
                this.gameObject.GetComponent<Renderer>().material = red;
            }
            if (player.GetComponent<Renderer>().material.name == green.name + " (Instance)")
            {
                Debug.Log("detected green material");
                this.gameObject.GetComponent<Renderer>().material = green;
            }
            if (player.GetComponent<Renderer>().material.name == blue.name + " (Instance)")
            {
                Debug.Log("detected blue material");
                this.gameObject.GetComponent<Renderer>().material = blue;
            }
            if (player.GetComponent<Renderer>().material.name == yellow.name + " (Instance)")
            {
                Debug.Log("detected yellow material");
                this.gameObject.GetComponent<Renderer>().material = yellow;
            }
            if (player.GetComponent<Renderer>().material.name == white.name + " (Instance)")
            {
                Debug.Log("detected white material");
                this.gameObject.GetComponent<Renderer>().material = white;
            }

        }




    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PicRefTrigger : MonoBehaviour
{
    public GameObject image1;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(true);
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPlatform : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("YOU WON!!!");
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}

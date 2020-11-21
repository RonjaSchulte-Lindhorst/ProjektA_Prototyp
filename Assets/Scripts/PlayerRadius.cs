using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRadius : MonoBehaviour
{
    bool irgendwashinundher = false;
    bool Trigger = false;

    public GameObject explodingPlatform;

    void Start()
    {

    }


    void Update()
    {
        if (Trigger == true && Input.GetKeyDown(KeyCode.B))
        {
         

            irgendwashinundher = true;
            Destroy(explodingPlatform);
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "ExplodeObject")
        {
            Trigger = true;


        }

        if (irgendwashinundher == true)
        {
            Destroy(other.gameObject);
        }
    }
}

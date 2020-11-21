using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereTrigger : MonoBehaviour
{
    public GameManager gameManager;
    //public GameObject plant;
    private Vector3 positionChange, scaleChange;
    //bool trigger = false;

    bool KeyDown = false;

    private void Awake()
    {
        scaleChange = new Vector3(5f, 5f, 10f);
    }

    private void Update()
    {
        Debug.Log(gameManager.LightPointCounter);
    }

    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "ExplodeObject")
        {
            
            if (gameManager.LightPointCounter >= 3)
            {
                if (Input.GetKeyDown(KeyCode.B))
                {
                    KeyDown = true;
                }

                if (KeyDown == true)
                {
                    Destroy(other.gameObject);
                    KeyDown = false;
                    gameManager.LightPointCounter -= 3;
                }
            }
        }

        if (other.tag == "GrowingPlatForm")
        {
            
            //trigger = true;

            
            if (gameManager.LightPointCounter >= 2)
            {
                if(Input.GetKeyDown(KeyCode.V))
                {
                    KeyDown = true;
                }

                if(KeyDown == true)
                {
                    other.transform.localScale = scaleChange;
                    KeyDown = false;
                    gameManager.LightPointCounter -= 2;
                    
                }

            }
        }
    }
}

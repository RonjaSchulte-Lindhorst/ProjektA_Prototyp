using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LichtPunkte : MonoBehaviour
{
    public GameManager gameManager;
    public bool collected = false;
    public GameObject miniMe;
    //public GameObject gameManager;
    public float offSet;
    

    void Start()
    {
      // gm = GameManager.instance;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && collected == false)
        {
            gameManager.LightPointCounter++;
           
            //miniMe.SetActive(true);
            collected = true;
        }
    }

    private void Update()
    {

        if (collected == true)

        {

            Destroy(this.gameObject);
            
        }  
    } 
}

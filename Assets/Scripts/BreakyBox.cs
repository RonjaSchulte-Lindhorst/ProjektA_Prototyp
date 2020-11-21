using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakyBox : MonoBehaviour

{
    //public GameObject Light;
    public GameObject newLight;
    public Lightfactory lightFactory;
    [SerializeField] GameObject lightPrefab;
    

    public void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);

        GameObject Light = Instantiate(lightPrefab, transform.position, transform.rotation);
        Light.GetComponent<GameManager>().breakyBox = gameObject;
        //Instantiate(Light, transform.position, Quaternion.identity);
        //newLight.GetComponent<LichtPunkte>().gameManager = this;
        //lightFactory.CreateNewLight(transform.position);
    }

}

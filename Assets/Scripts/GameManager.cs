using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public  int LightPointCounter = 0;
    public GameObject Lichteinsammler;
    public GameObject SelfLight;
    public GameObject Player;
    public float Timer = 0;
    //public float dyingLights;
    //public GameObject lightBullet;
    //public float newSizeX = 3;
    //public float newSizeY = 3;
    //public float newSizeZ = 3;

    //GameObject newLight;

    public GameObject breakyBox;





    void Update()
    {
        


        /*if (LightPointCounter > 0)
        {
            Timer += Time.deltaTime;
        }

        if (Timer >= dyingLights) 
        {
            if (LightPointCounter > 0)
            {
                LightPointCounter--;

            }

            Timer = 0; // Timer wird zurueckgesetzt
        }*/
        

        Lichteinsammler.GetComponent<Text>().text = "Lichtpunkte: " + LightPointCounter.ToString();
        
        
        SelfLight.GetComponent<Light>().range = 80 * LightPointCounter;
        SelfLight.GetComponent<Light>().intensity = 600 * LightPointCounter;


        Shot();
        

    }

    void Shot()
    {
       

        
    }

}

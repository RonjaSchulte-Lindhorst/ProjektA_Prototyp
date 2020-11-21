using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class Hieroglyphe : MonoBehaviour

{



    public static int theScore;



    public bool collected = false;



    void OnTriggerEnter(Collider collider)

    {

        collected = true;



    }

    public void Update()

    {

        if (collected == true)

        {



            theScore += 1;

            Debug.Log(theScore);





            Destroy(gameObject);

        }

    }

}
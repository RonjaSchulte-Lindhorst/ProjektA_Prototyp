using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class Aussparung : Hieroglyphe

{

    public GameObject SetAktiv;

    public GameObject Disappear;

    public GameObject SetAktiveAndStay;

    float timer = 0;



    private void OnTriggerEnter(Collider other)

    {



        if (other.gameObject.CompareTag("Player"))

        {



            if (theScore == 0)

            {

                Debug.Log(theScore);

                return;



            }



            if (theScore >= 1)

            {

                Debug.Log("jetzt sollte es auch hier 1 sein");

                Debug.Log(theScore);

                Disappear.SetActive(false);

                SetAktiv.SetActive(true);

                SetAktiveAndStay.SetActive(true);
                theScore = 0;











            }

        }

    }





    public new void Update()

    {





        if (SetAktiv == true)

        {

            timer += Time.deltaTime;

            if (timer >= 15)

            {

                SetAktiv.SetActive(false);

                timer = 0;

            }

        }





    }









}
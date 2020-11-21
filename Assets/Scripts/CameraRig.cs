using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraRig : MonoBehaviour
{
    [SerializeField] GameObject targetObject;
    [SerializeField] float followStrength;

  


   

    


    private void Update()
    {
       
        FollowTarget();
    }
  

    void FollowTarget()
    {

        transform.position = Vector3.Lerp(transform.position, targetObject.transform.position, followStrength * Time.deltaTime);

    }

}


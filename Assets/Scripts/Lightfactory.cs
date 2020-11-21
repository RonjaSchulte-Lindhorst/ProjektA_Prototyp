using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightfactory : MonoBehaviour
{
    public GameObject lightPoint;
    public GameObject breakyBox;
    public GameManager gamemanager;
    public virtual void CreateNewLight()
    {
       GameObject newLight = Instantiate(lightPoint, breakyBox.transform.position, Quaternion.identity);
        newLight.GetComponent<BreakyBox>().lightFactory = this;

    }
}

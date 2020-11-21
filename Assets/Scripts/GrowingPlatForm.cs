using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowingPlatForm : MonoBehaviour
{
    public float speed;
    public float stopppingDistance;
    public float retreatDistance;

    public Transform player;

    void Start()
    {
      player = GameObject.FindGameObjectWithTag("Player").transform;  
    }

    
    void Update()
    {
        
    }
}

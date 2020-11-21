/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float floatSpeed;
   
    //GameManager gm;

    Rigidbody playerRigidbody;
    
    public Vector3 scaleChange;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        //gm = GameManager.instance;
        
    }

    private void Update()
    {
        float yVelocity;

        if (Input.GetKey(KeyCode.Space))
        {
            yVelocity = floatSpeed;
        }
        else
        {
            yVelocity = playerRigidbody.velocity.y;
        }
        

        playerRigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, yVelocity, Input.GetAxis("Vertical") * moveSpeed);
    }

    
    }*/


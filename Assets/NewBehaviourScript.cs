using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float floatSpeed;

    Rigidbody playerRigidbody;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
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
        Debug.Log(yVelocity);

        playerRigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, yVelocity, Input.GetAxis("Vertical") * moveSpeed);
    }
}

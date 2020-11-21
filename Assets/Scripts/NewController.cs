using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewController : MonoBehaviour
{
    public float movementSpeed = 5;
    public float jumpForce;
    int jumps;
    public Vector3 Velocity = Vector3.zero;
    Rigidbody rb;
    
    //GroundCheck
    public bool isGrounded = false;
    public bool isInAir = false;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatisGround;
    private Vector3 direction;
    public float maxDistance;

    public GameObject gameManager;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");
        Velocity.x = xInput * movementSpeed;
        Velocity.z = zInput * movementSpeed;

        transform.Translate(Velocity * Time.deltaTime);
    }
    void Update()
    {
        direction = Vector3.down;
        RaycastHit hit;
        

        

        if (Physics.Raycast(feetPos.position, direction, out hit, maxDistance, whatisGround))
        {
            Debug.DrawRay(feetPos.position, direction * hit.distance, Color.yellow);
            //Debug.Log("Did Hit"+hit.collider.gameObject);
            isGrounded = true;
        }
        else
        {
            Debug.DrawRay(feetPos.position, direction * 1000, Color.white);
            //Debug.Log("Did not Hit");
            
            isGrounded = false;
        }


        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space) )
        {
            Debug.Log("trytojump");
            rb.velocity = Vector3.up * jumpForce;
            //jumps = 0;
            
        }


        //Shot();
    }

 
}

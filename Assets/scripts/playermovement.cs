using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{


    private Rigidbody2D myRigidbody;

    public float moveSpeed;
    public float jumpForce;
  

  

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }


    


    void Update()
    {
        myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);

        
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))

                {

           
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);

        }



        


    }



}

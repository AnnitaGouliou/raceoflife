using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    GameObject player1;
    // Start is called before the first frame update
    void Start()
    {
        player1 = gameObject.transform.parent.gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == "Ground")
        {
            player1.GetComponent<playermovement>().isGrounded = true;
        }


    }




    private void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.collider.tag == "Ground")
        {
            player1.GetComponent<playermovement>().isGrounded = false;
        }

    }


}

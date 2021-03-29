using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player3movement : MonoBehaviour
{
    private Rigidbody2D myRigidbody;

    public float moveSpeed;
    public float jumpForce;
    public bool isGrounded = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Obstacle"))
        {

            DoDamageToPlayer();
        }

        else if (collision.CompareTag("player3"))

        {
            Destroy(gameObject);
        }
        else if (collision.CompareTag("player2"))

        {

            GetComponent<playermovement>().enabled = true;
            //     myRigidbody = GetComponent<Rigidbody2D>();



            //       Jump1();
            //       myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);





            //     void Jump1()
            //   {
            //|| Input.GetMouseButtonDown(0)
            //       if (Input.GetButtonDown("Jump") && isGrounded == true)

            //       {

            //           gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 8f), ForceMode2D.Impulse);
            // myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);

            //      }

            //  }
        }


        else if (collision.CompareTag("End"))
        {

            EndPlayer();
        }


    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Obstacle"))
        {

            DoDamageToPlayer();
        }

        else if (collision.gameObject.CompareTag("player3"))

        {
            Destroy(gameObject);
        }


        else if (collision.gameObject.CompareTag("player2"))

        {
            GetComponent<playermovement>().enabled = true;

            //  myRigidbody = GetComponent<Rigidbody2D>();




            //   Jump1();
            //   myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);




            //  void Jump1()
            //   {
            //|| Input.GetMouseButtonDown(0)
            //       if (Input.GetButtonDown("Jump") && isGrounded == true)

            //       {

            //           gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 8f), ForceMode2D.Impulse);
            // myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);

            //       }

            //   }
        }

        else if (collision.gameObject.CompareTag("End"))
        {

            EndPlayer();
        }

    }

    void DoDamageToPlayer()

    {

        SceneManager.LoadScene("Game");
    }




    void EndPlayer()

    {

        SceneManager.LoadScene("End");
    }








}
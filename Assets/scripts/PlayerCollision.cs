using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Obstacle"))
        {

            DoDamageToPlayer();
        }

        else if (collision.CompareTag("player2"))

        {
            Destroy(gameObject);
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

        else if (collision.gameObject.CompareTag("player2"))

        {
            Destroy(gameObject);
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

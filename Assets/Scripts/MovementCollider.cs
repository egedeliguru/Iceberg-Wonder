using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementCollider : MonoBehaviour {

    public PlayerMovement movement;
     

    private void Start()
    {
        Debug.Log("MovementCollider Start");   
    }

    private void OnCollisionEnter(Collision collision)
    {
        //player touches iceberg 
        if(collision.collider.tag == "iceberg")
        {
            Debug.Log("Hitted İceberg");
            movement.enabled = false;
            SceneManager.LoadScene("Credits");
            //FindObjectOfType<GameManager>().EndGame();
        }
    

    }
}

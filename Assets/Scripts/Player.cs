using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] public int score = 0;
    void Start()
    {
        transform.position = new Vector3(-6.35f, 0.07f, -6.35f);
        Instructions();
    }

    void FixedUpdate()
    {
        Movement();
    }

    //Function to move Player
    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;
        float zValue = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;
        transform.Translate(xValue, 0, zValue);
    }

    void Instructions()
    {
        Debug.Log("Welcome to the GAME!");
        Debug.Log("Move the player with W, A, S, and D");
        Debug.Log("Avoid all the obstacles and the walls!");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Obstacle")
        {
            score++;
            transform.position = new Vector3(-6.35f, 0.07f, -6.35f);
            if (collision.gameObject.tag == "Obstacle")
            {
                Destroy(collision.gameObject);
            }
            Debug.Log("Objects bumped into: " + score);
        }
    }
}

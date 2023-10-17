using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerContoller : MonoBehaviour
{
    private GameObject projectile;
    private float speed = 5f;
    private float centerToEdge = 1f;
    private float move;

    void Start()
    {
        // Initialization code here.
    }

    void Update()
    {
        // Update code here
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        // Player movement logic here

        transform.Translate(Vector3.right * speed * move * Time.deltaTime);    }

    public void OnMove(InputValue input)
    {
        // Handle movement input from the player here
        move = input.Get<Vector2>().x;

        if (move > 0)    //gives the int 1 or -1 based of vector2 input
        {
            move = 1;
        }
        else if (move < 0)
        {
            move = -1;
        }
    }

    public void OnFire()
    {
        // Handle firing or shooting logic here
        Instantiate(projectile, transform.position, Quaternion.identity);
    }
}
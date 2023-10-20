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
        centerToEdge = 15f; //Sets the Right Edge.
    }

    void Update()
    {
        // Update code here
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        // Player movement logic here
        transform.Translate(Vector3.right * speed * move * Time.deltaTime);
        if(Mathf.Abs(transform.position.x) > centerToEdge)
        {
            float edge = centerToEdge;
            if(transform.position.x < 0f)
            {
                edge = -centerToEdge;
            }
            transform.position = new Vector3(centerToEdge, transform.position.y, transform.position.z);
        }
    }

    public void OnMove(InputValue input)
    {
        // Handle movement input from the player here
        Vector2 moveDirection = input.Get<Vector2>();
        move = moveDirection.x;
        Debug.Log(move);
    }

    private void OnFire()
    {
        Instantiate(projectile, transform.position + Vector3.up, projectile.transform.rotation);
        Instantiate(projectile, transform.position, Quaternion.identity);
    }
}
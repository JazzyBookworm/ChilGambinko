using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMove : MonoBehaviour
{
    public CharacterController controller;
    public float playerSpeed = 2.0f;
    private Vector2 direction;
    private Vector2 playerVelocity;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        playerVelocity = direction * playerSpeed;
        controller.Move(playerVelocity * Time.deltaTime);
    }
}

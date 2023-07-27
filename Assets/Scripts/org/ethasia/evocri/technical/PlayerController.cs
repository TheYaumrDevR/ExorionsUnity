using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed = 5;

    [SerializeField]
    private Rigidbody rigidBody;

    private Vector3 rotationSpeed = new Vector3(0, 120, 0);
    private Rigidbody rb;
    private Vector2 inputDirection;

    void Start()
    {
        
    }

    void Update()
    {
        Vector2 inputs = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        inputDirection = inputs.normalized;
    }

    void FixedUpdate() 
    {
        Quaternion deltaRotation = Quaternion.Euler(inputDirection.x * rotationSpeed * Time.deltaTime);
        rigidBody.MoveRotation(rigidBody.rotation * deltaRotation);
        rigidBody.MovePosition(rigidBody.position + transform.forward * movementSpeed * inputDirection.y * Time.deltaTime);
    }
}

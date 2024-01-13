using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Float variables
    private float moveForce = 10f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody playerRigidBody;
    private Vector3 directionInput;
    
    void Start(){
        playerRigidBody = GetComponent<Rigidbody>();
        playerRigidBody.freezeRotation = true;
    }

    void FixedUpdate(){
        MovePlayer();
    }
    void Update()
    {
        // Getting Player Input
        InputChecker();
        SpeedControler();
    }

    void InputChecker(){
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    void MovePlayer(){
        directionInput = Vector3.forward * verticalInput + Vector3.right * horizontalInput;
        playerRigidBody.AddForce(directionInput.normalized * moveForce * 10f, ForceMode.Force);
    }

    void SpeedControler(){
        Vector3 flatVelocity = new Vector3(playerRigidBody.velocity.x, 0f, playerRigidBody.velocity.z);

        if(flatVelocity.magnitude > moveForce){
            Vector3 limitedVelocity = flatVelocity.normalized * moveForce;
            playerRigidBody.velocity = new Vector3(limitedVelocity.x, 0f, limitedVelocity.z);
        }
    }
}

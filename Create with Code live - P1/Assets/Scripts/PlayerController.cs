using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 15f;
    private float turnSpeed = 50f;
    private float horizontalInput, forwardInput;
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        if(!gameOver){
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        }
    }

    void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag("Bus") || other.gameObject.CompareTag("Obstacle")){
        Debug.Log("Game Over!");
        gameOver = true;
        }
    }
}

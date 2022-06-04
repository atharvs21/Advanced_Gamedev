using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.05f;
    public float turnSpeed = 45.0f;
    public float horizontalInput;
    public float forwardInput;

    public string HorizontalAxes;
    public string VerticalAxes;

    public Rigidbody vehicleRigidBody;

    private bool hasWon = false;
    private int points = 0;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis(HorizontalAxes);
        forwardInput = Input.GetAxis(VerticalAxes);

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        if (transform.position.z > 125 && !hasWon)
        {
            vehicleRigidBody.AddForce(Vector3.up * 1000000);
            hasWon = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        vehicleRigidBody.AddForce(Vector3.up * 1000);

        Destroy(other.gameObject);

        points++;

        Debug.Log("Points " + points);
    }
}

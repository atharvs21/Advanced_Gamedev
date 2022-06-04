using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 20f;
    public GameObject player;
    private PlayerController playerControllerScript;
    void Start()
    {
        playerControllerScript = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControllerScript.gameOver != true)
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}

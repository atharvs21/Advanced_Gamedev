using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float maxBound = 30.0f;
    private float minBound = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > maxBound || transform.position.z < minBound){
            Destroy(gameObject);
            Debug.Log("GameOver!");
        }        
    }
}

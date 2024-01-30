using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDcontroller : MonoBehaviour
{
    public float forceAmount = 10f;
    public float maxVelocity = 10f;
    private Rigidbody rb;

    // public GameObject ballPrefab; 
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(forceAmount * Vector3.forward);
            Debug.Log("W pressed");
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(forceAmount * Vector3.back);
            Debug.Log("S pressed");
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(forceAmount * Vector3.left);
            Debug.Log("A pressed");
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(forceAmount * Vector3.right);
            Debug.Log("D pressed");
        }
        
        if (rb.velocity.magnitude > maxVelocity)
        {
            Vector3 newVelocity = rb.velocity.normalized;
            newVelocity *= maxVelocity;
            rb.velocity = newVelocity;
        }

        // if (Input.GetKey(KeyCode.R)) 
        // {
        //     Destroy(this);
        //     Instantiate(ballPrefab);
        // }
    }
}

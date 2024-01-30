using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    //private Rigidbody rb;
    public float speed = 1;
    private Vector3 startPos;
    private Vector3 endPos;
    
    // Start is called before the first frame update
    void Start()
    {
        // rb = GetComponent<Rigidbody>();
        startPos = new Vector3(-14, 5, 27);
        endPos = new Vector3(14, 5, 27);
    }

    // Update is called once per frame
    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(startPos, endPos, time);
    }

    private void OnCollisionEnter()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
}

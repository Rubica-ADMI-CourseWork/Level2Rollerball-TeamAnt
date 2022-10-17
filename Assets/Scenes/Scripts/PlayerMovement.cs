using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   public Vector2 moveInput = Vector2.zero;
    public float moveMent;
    public float moveSpeed;
    public float moveTime;
    public float moveDistance;
    Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rb.velocity = Vector2.zero;
    }

    private void Update()
    {
        float yValue;
        yValue = moveInput.y;
        yValue =  10f;
    }
    // Cancel out negative value
    

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMovement : MonoBehaviour
{
    Rigidbody2D piperb;
    public float pipespeed;
    // Start is called before the first frame update
    void Start()
    {
        piperb = GetComponent<Rigidbody2D>();
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        piperb.velocity = Vector2.left * pipespeed;
    }
}

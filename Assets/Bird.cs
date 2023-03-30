using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {
    public float velocity = 1;
    public Rigidbody2D rg;
    // Use this for initialization
    void Start()
    {
        // rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { rg.velocity = Vector2.up * velocity; }
    }
}

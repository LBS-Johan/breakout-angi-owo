using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, 1);
    }
    //Update is called once per frame
    private void Update()
    {
        float speed = 4;
        rb.velocity = rb.velocity.normalized * speed;
    }
}

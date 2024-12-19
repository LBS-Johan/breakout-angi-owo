using System;
using UnityEngine;

Rigidbody2D rb;
//Start is called before the first frame update
void Start()
{
    rb = GetComponent<Rigidbody2D>();
}

T GetComponent<T>()
{
    throw new NotImplementedException();
}

//Update is called once per frame 
void Update()
{
    rb.velocity = new Vector2(0, 0);
    if (Input.GetKey(KeyCode.RightArrow))
    {
        rb.velocity = new Vector2(7, 0);
    }
    if (Input.GetKey(KeyCode.LeftArrow))
    {
        rb.velocity = new Vector2(-7, 0);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private Rigidbody2D _rigidbody2d;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        _rigidbody2d.velocity = new Vector2(horizontal * speed * Time.deltaTime, vertical * speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField]
    Vector2 moveDir = Vector2.zero;

    [SerializeField]
    float speed = 10f;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = moveDir * speed;
    }

    void OnMove(InputValue _value)
    {
        Vector2 move = _value.Get<Vector2>();

        moveDir = move;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMovement: MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    public float moveSpeed;
    private float dirX;
    private bool facingRight = true;
    private Vector3 localScale;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        localScale = transform.localScale;
        moveSpeed = 10f;
    }

    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * moveSpeed;
        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y == 0)
            rb.AddForce(Vector2.up * 300f);
        if (Mathf.Abs(dirX) > 0 && rb.velocity.y == 0)
            anim.SetBool("isRun", true);
        else
            anim.SetBool("isRun", false);
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, rb.velocity.y);
    }
    private void LateUpdate()
    {
        if (dirX < 0)
            facingRight = true;
        else if (dirX > 0)
            facingRight = false;
        if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
            localScale.x *= -1;
        transform.localScale = localScale;
    }
}

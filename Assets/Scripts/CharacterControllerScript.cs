using UnityEngine;
using System.Collections;

public class CharacterControllerScript : MonoBehaviour
{

    public float speed;
    public float jump;
    public Animator anim;
    public GameObject rayOrigin;
    public float rayCheckDistance;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    void FixedUpdate()
    {
        float MoveX = Input.GetAxis("Horizontal");
        if (MoveX < 0 || MoveX > 0)
        {
            anim.SetBool("isRun", true);
        }
        else anim.SetBool("isRun", false);

        rb.velocity = new Vector3(MoveX * speed, rb.velocity.y, 0);

    }
}

using UnityEngine;
using System.Collections;

public class CharacterControllerScript : MonoBehaviour
{

    public float speed;
    public float jump;
    public GameObject rayOrigin;
    public float rayCheckDistance;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float MoveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(MoveX * speed, rb.velocity.y, 0);

    }
}

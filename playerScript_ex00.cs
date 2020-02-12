using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript_ex00 : MonoBehaviour
{
    public bool moveable;
    public float speed;
    public float center;
    [SerializeField] float up_velocity;
    [SerializeField] LayerMask ground_layer;

    // Start is called before the first frame update
    void Start()
    {
        moveable = false;
    }

    bool canJump()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, center, ground_layer);
        if (hit.collider != null)
            return true;
        return false;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveable && canJump() && Input.GetKeyDown("space"))
            this.GetComponent<Rigidbody2D>().AddForce(Vector3.up * up_velocity);
        if (Input.GetKey("left") && moveable)
            transform.Translate(Vector3.left * speed);
        if (Input.GetKey("right") && moveable)
            transform.Translate(Vector3.right * speed);
    }
}

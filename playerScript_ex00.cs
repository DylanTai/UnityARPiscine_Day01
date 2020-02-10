using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript_ex00 : MonoBehaviour
{
    public bool moveable;
    public float speed;
    [SerializeField] float up_velocity;
    [SerializeField] bool jump;

    // Start is called before the first frame update
    void Start()
    {
        moveable = false;
        jump = false;
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.layer == 8)
            jump = true;
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.layer == 8)
            jump = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveable && jump && Input.GetKeyDown("space"))
            this.GetComponent<Rigidbody2D>().AddForce(Vector3.up * up_velocity);
        if (Input.GetKey("left") && moveable)
            transform.Translate(Vector3.left * speed);
        if (Input.GetKey("right") && moveable)
            transform.Translate(Vector3.right * speed);
    }
}

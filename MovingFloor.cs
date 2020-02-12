using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFloor : MonoBehaviour
{
    [SerializeField] int direction;
    private float velocity;
    private bool go;
    private float time;
    private float flip_dir;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        go = true;
        velocity = 0.02f;
        flip_dir = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (direction == 1)
            this.transform.Translate(Vector2.up * velocity);
        else if (direction == 0)
            this.transform.Translate(Vector3.down * velocity);
        if (time >= flip_dir)
        {
            if (direction == 1)
                direction = 0;
            else
                direction = 1;
            time -= flip_dir;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    readonly float runSpeed = 2f;
    readonly float jumpHeight = 4f;

    float horizontal;
    float vertical;

    bool onHorizontal;
    bool onVertical;

    bool grounded;

    Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();

        grounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("Going right or left");
            this.onHorizontal = true;
            this.onVertical = false;
        }
         if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("going up or down");
            this.onVertical = true;
            this.onHorizontal = false;
        }

        if (body.velocity.y == 0f)
        {
            grounded = true;
        }

        if(Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            body.velocity += jumpHeight * Vector3.up;
        }
    }

    private void FixedUpdate()
    {
        if (onHorizontal)
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = 0f;
        }
        else if (onVertical)
        {
            vertical = Input.GetAxis("Vertical");
            horizontal = 0f;
        }

        body.velocity = new Vector3(
            Mathf.Lerp(0, this.horizontal * runSpeed, 0.8f),
            body.velocity.y,
            Mathf.Lerp(0, this.vertical * runSpeed, 0.8f)
        );
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    readonly float runSpeed = 2f;
    readonly float jumpHeight = 2f;

    bool grounded;
    float yVelocity;

    Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();

        yVelocity = 0;
        grounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(body.velocity.y == 0f)
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
        body.velocity = new Vector3(
            Mathf.Lerp(0, Input.GetAxis("Horizontal") * runSpeed, 0.8f),
            body.velocity.y,
            Mathf.Lerp(0, Input.GetAxis("Vertical") * runSpeed, 0.8f)
        );
    }
}

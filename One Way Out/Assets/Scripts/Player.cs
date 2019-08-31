using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    readonly float runSpeed = 2f;
    readonly float jumpHeight = 4f;

    bool grounded;

    AudioSource audioSource;
    AudioClip jump;
    AudioClip step;

    Animator animator;

    Rigidbody body;
    public UIManager manager;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();

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

        if (grounded)
        {
            animator.SetBool("Jumping", false);
        }
        else
        {
            animator.SetBool("Jumping", true);
        }
    }

    private void FixedUpdate()
<<<<<<< Updated upstream
    {
=======
    {
        if (onHorizontal)
        {
            horizontal = Input.GetAxis("Horizontal");
            if(horizontal > 0)
            {
                animator.SetBool("Right", true);
                animator.SetBool("Front", false);
                animator.SetBool("Back", false);
                animator.SetBool("Left", false);
            } else if (horizontal < 0)
            {
                animator.SetBool("Left", true);
                animator.SetBool("Right", false);
                animator.SetBool("Front", false);
                animator.SetBool("Back", false);
            }

            vertical = 0f;
        }
        else if (onVertical)
        {
            vertical = Input.GetAxis("Vertical");
            horizontal = 0f;

            if (vertical > 0)
            {
                animator.SetBool("Left", false);
                animator.SetBool("Right", false);
                animator.SetBool("Front", false);
                animator.SetBool("Back", true);
            }
            else if (vertical < 0)
            {
                animator.SetBool("Left", false);
                animator.SetBool("Right", false);
                animator.SetBool("Front", true);
                animator.SetBool("Back", false);
            }
        }

        animator.SetFloat("Speed", body.velocity.x + body.velocity.z);

>>>>>>> Stashed changes
        body.velocity = new Vector3(
            Mathf.Lerp(0, Input.GetAxis("Horizontal") * runSpeed, 0.8f),
            body.velocity.y,
            Mathf.Lerp(0, Input.GetAxis("Vertical") * runSpeed, 0.8f)
        );
    }

    public void Respawn(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
        manager.ShowDialogue("Well, looks like you died!");
    }
}

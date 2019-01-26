using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public Animator animator;
    public Rigidbody rigidbody;

    private float h;
    private float v;

    private float moveX; // left, right
    private float moveZ;    // up, down
    private float speedH = 150f; // left, right
    private float speedZ = 150f;  // up, down

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // The key movement of the cat character

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.transform.Translate(0, 0, speedH * Time.deltaTime);
            animator.Play("Run", -1, 0);

        }
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        animator.SetFloat("h", h);
        animator.SetFloat("v", v);

        moveX = h * speedH * Time.deltaTime; // check the direction key(left and right) , the distance of movement
        moveZ = v * speedZ * Time.deltaTime; 

        rigidbody.velocity = new Vector3(moveX, 0, moveZ);
    }
}

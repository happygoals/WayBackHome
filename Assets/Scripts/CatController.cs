using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public Animator animator;

    private float h;
    private float v;

    private float moveX;
    private float moveY;
    private float speedH = 50f;
    private float speedV = 80f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // The key movement of the cat character

        if (Input.GetKeyDown(KeyCode.Space))
        {

            animator.Play("Run", -1, 0);

        }
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        animator.SetFloat("h", h);
        animator.SetFloat("v", v);

    }
}

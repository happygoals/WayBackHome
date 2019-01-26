using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public int timer = 0;
    public float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Initialize");
    }

    // Update is called once per frame
    void Update()
    {
        // The key movement of the cat character
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-speed * Time.deltaTime, 0,0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0, 0, speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        timer = timer + 1;
        Debug.Log(timer + "th Updating");
    }
}
